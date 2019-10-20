import React, { Component } from 'react';
import { Link } from 'react-router-dom';

export class Home extends Component {
  static displayName = Home.name;

  render() {
    return (
      <div>
        <h1>Welcome to Binner</h1>
        <p>Binner is an inventory management app for makers, hobbyists and professionals.</p>
        <p>Choose an action:</p>
        <ul>
          <li><Link to="/inventory/add">Add Inventory</Link></li>
          <li><Link to="/search">Search inventory</Link></li>
          <li><Link to="/datasheets">Datasheet Search</Link></li>
          <li><Link to="/order">Order Low Stock</Link></li>
          <li><Link to="/categories">Manage Categories</Link></li>
          <li><Link to="/projects">Manage Projects</Link></li>
        </ul>

        <h2>Dashboard</h2>
        <div className="divTable">
          <div className="divTableBody">
            <div className="divTableRow">
              <div className="divTableCell header">Inventory</div>
              <div className="divTableCell header">Low Stock</div>
              <div className="divTableCell header">Projects</div>
            </div>
            <div className="divTableRow">
              <div className="divTableCell">12,000 parts<br />$800.00 value</div>
              <div className="divTableCell">4 Parts</div>
              <div className="divTableCell">2 Projects</div>
            </div>
          </div>
        </div>
      </div>
    );
  }
}
