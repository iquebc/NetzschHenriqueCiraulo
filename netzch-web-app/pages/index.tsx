import { useCallback, useEffect, useState } from "react";
import SendMessageComponent from "./components/sendMessageComponent";
import ShowMessageComponent from "./components/showMessageComponent";
import Message from "../core/entities/message";

export default function Home() {
  const [messages, setMessages] = useState([]);

  const updateMessage = useCallback(getMessage, []);

  async function getMessage() {
    const result = await fetch("https://localhost:7288/message");
    const data = await result.json();
    const messages = [];
    data.forEach((data) => {
       const message = new Message(data.message, data.sender.name);
       messages.push(message);
    });
    setMessages(messages);
  }

  useEffect(() => {
    updateMessage();
  }, [updateMessage]);

  return (
    <>
      <SendMessageComponent updateMessage={updateMessage}></SendMessageComponent>
      <ShowMessageComponent messages={messages} updateMessage={updateMessage}></ShowMessageComponent>
    </>
  );
}
