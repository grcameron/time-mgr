import React, { Component } from 'react';
import { Logs } from './Logs';
import { LogEntry } from './LogEntry';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div>
        <Logs />
        <LogEntry />
      </div>
    );
  }
}
