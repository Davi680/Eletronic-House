/* RESET global */
*,
*::before,
*::after {
  box-sizing: border-box;
}
 
* {
  margin: 0;
}
 
body,
h1,
h2,
h3,
h4,
p,
figure,
blockquote,
dl,
dd {
  margin-block-end: 0;
}
 
body {
    font-family: 'Albert Sans', Arial, Helvetica, sans-serif;
    width: 1000px;
    height: auto;
    max-width: 1000px;
    background-color: coral;
    margin: 0 auto;
    color: #f8f8f8;
}
 
#titulo {
    width: 100%;
    height: auto;
    background-color: orangered;
    display: flex;
    flex-direction: column;
    align-items: center;
}
 
#titulo img {
    width: 70%;
    height: auto;
    border-radius: 8 px;
}
#conteudo {
    width: 1000 px;
    height: auto;
    background-color: orangered;
    padding: 60 px;
    padding-top: 50 px;
    padding-bottom: 30 px;
}
 #menu {
  width: 100 px;
  height: 70 px;
  background-color: #fefefe;
  color: orangered;
  padding-top: 30 px;
 
}
 
#menu ul {
  display: flex;
  justify-content: space-around;
}
 
#menu ul li {
  list-style: none;
 
}
 
#menu ul li a {
  text-decoration: none;
  color: orangered;
  font-size: 22 px;
  font-weight: 600 px;
} gi