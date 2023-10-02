import Message from "../../core/entities/message";
import styles from "../../styles/message.module.css";

type ShowMessageComponentProps = {
  messages: Message[];
  updateMessage: (e: any) => void;
};

export default function ShowMessageComponent(props: ShowMessageComponentProps) {
  if (props.messages.length == 0) return <p>No Message Received</p>;

  return (
    <div>
      <h2 className={styles.titulo}>Messages</h2>
      <div className={styles.forms}>
        <button type="button" onClick={props.updateMessage}>
          Update Messages
        </button>
        <ul className={styles.list}>
          {props.messages.map((x) => {
            return <li>{x.getMessage()}</li>;
          })}
        </ul>
      </div>
    </div>
  );
}
