export default class Message {
  constructor(private message: string, private userName: string) {
    this.message = message;
    this.userName = userName;
  }

  public getMessage() {
    return `${this.userName}:${this.message}`;
  }

  ObjToJson() {
    return { message: this.message, userName: this.userName };
  }
}
