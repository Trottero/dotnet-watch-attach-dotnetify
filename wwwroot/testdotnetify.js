class Testdotnetify extends React.Component {
  constructor(props) {
    super(props);
    dotnetify.react.connect("testdotnetify", this);
    this.state = { Greetings: "", ServerTime: "", Count: 0 };
  }

  render() {
    return (
      <div>
        <p>{this.state.Greetings}</p>
        <p>Server time is: {this.state.ServerTime}</p>
        <p>The current count is: {this.state.Count}</p>
      </div>
    );
  }
}

ReactDOM.render(<Testdotnetify />, document.getElementById("App"));
