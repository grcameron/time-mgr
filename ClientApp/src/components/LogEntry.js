import React, { Component } from 'react';

export class LogEntry extends Component {
  static displayName = LogEntry.name;

  render () {
    return (
      <div>
        {/* Todo: Button to add logentry row as well as functionality to pass to controller and update mongodb */}
        <p>Log Entry stuff</p>        
        <input type="button" value="Add Log" />
      </div>
    );
  }
}
