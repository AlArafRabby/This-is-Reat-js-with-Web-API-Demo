import React,{Component} from 'react'

class FirstClass extends Component
{
DoThisFormClass(b)
{
    alert(b)
}
constructor()
{
    super();
    this.RefreshNow=this.RefreshNow.bind(this);

}

RefreshNow()
{
    this.forceUpdate();
}

    render()
    {
    return (
        /*<div>
            <button onClick={this.DoThisFormClass.bind(this,"class clicked")}>Click</button>
             <h1>This is {this.props.name}</h1>
        </div>*/
        <div>
             <button onClick={this.RefreshNow}>Random Change</button>
        <h1>{Math.random()}</h1>
        </div>
        
    ) 
  
       

    }
}

export default FirstClass