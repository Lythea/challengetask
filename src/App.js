import React, { useState, useEffect } from "react";

function Counter() {
  const [count, setCount] = useState(0);

  const increment = () => setCount(count + 1);
  const decrement = () => setCount(count - 1);

  return (
    <div>
      <h2>Counter</h2>
      <p>Count: {count}</p>
      <button onClick={increment}>Increment</button>
      <button onClick={decrement}>Decrement</button>
    </div>
  );
}

function PostFetcher() {
  const [post, setPost] = useState(null);

  useEffect(() => {
    fetch("https://jsonplaceholder.typicode.com/posts")
      .then((response) => response.json())
      .then((data) => {
        setPost(data[0]);
      })
      .catch((error) => console.error("Error fetching data:", error));
  }, []);
  return (
    <div>
      <h2>First Post</h2>
      {post ? <p>{post.title}</p> : <p>Loading...</p>}
    </div>
  );
}

function App() {
  const [count, setCount] = useState(0);

  useEffect(() => {
    console.log(`Count is ${count}`);
  }, [count]);

  return (
    <div>
      <Counter />
      <PostFetcher />
    </div>
  );
}

export default App;
