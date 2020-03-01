import React, { Component } from 'react';
import ReactDom from 'react-dom';

class NewDemo extends Component {


MyFunc()
{

    var container=document.getElementById("intID");
    var element=<h2>The demo element has changed</h2>

    var callbabck=function(){
        alert("Demo Alert");
    }
    ReactDom.hydrate(element,container,callbabck);
}


    render() {
        return (
            <div>
                <button onClick={this.MyFunc}>Click Demo</button>
                <h1 id="intID">This is Demo</h1>
            </div>
        );
    }
}

export default NewDemo;