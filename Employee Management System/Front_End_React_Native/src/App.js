import React from 'react';
import logo from './logo.svg';
import './App.css';
import './mycomponents/First';
import First from './mycomponents/First';
import TestClass from './mycomponents/TestClass';
import Welcome from './mycomponents/Welcome';
import NewDemo from './mycomponents/NewDemo';
import Form from './mycomponents/Form';
import Button from 'react-bootstrap/Button';
import {Home} from './mycomponents/Home';
import {Department} from './mycomponents/Department';
import {Employee} from './mycomponents/Employee';
import { BrowserRouter , Route,Switch } from 'react-router-dom'
import {Navigation} from './mycomponents/Navigation'
function App() {
  return (
    <BrowserRouter>
    <div className="container">
     <p className="md-5 d-flex justify-content-center">This is Reat js with Web API Demo</p>
     <p className="md-5 d-flex justify-content-center">Employee Management portal</p>
     <Navigation></Navigation>
      <Switch>
        <Route path="/" component={Home} exact/>
        <Route path="/department" component={Department} />
        <Route path="/employee" component={Employee} />
      </Switch>
    </div>
    </BrowserRouter>
  );
}

export default App;
