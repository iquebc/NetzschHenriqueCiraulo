import { BaseSyntheticEvent, useState } from "react";
import Message from "./../../core/entities/message";
import styles from "../../styles/message.module.css";

type SendMessageComponentProps = {
  updateMessage: (e: any) => void;
};

export default function SendMessageComponent(props: SendMessageComponentProps) {
  async function handleSubmit(e: BaseSyntheticEvent) {
    e.preventDefault();
    const message: Message = new Message(
      e.target.message.value,
      e.target.userName.value
    );
    const result = await fetch("http://localhost:5161/message", {
      method: "POST",

      headers: { "Content-Type": "application/json" },
      body: JSON.stringify(message),
    });
    if (result.status !== 200) {
      alert("error!");
      return;
    }

    props.updateMessage([]);
    alert("Message sent sucefully");
  }

  return (
    <>
      <h2 className={styles.titulo}>Send Message to a ClienteApp</h2>
      <form onSubmit={handleSubmit} className={styles.forms}>
        <div className={styles.formGroup}>
          <label>UserName</label>
          <input type="text" id="txtUserName" name="userName" required></input>
        </div>
        <div className={styles.formGroup}>
          <label>Message</label>
          <textarea
            id="txtMessage"
            name="message"
            cols={40}
            rows={5}
            required
          ></textarea>
        </div>
        <button id="btnSendMessage">Send Message</button>
      </form>
    </>
  );
}
