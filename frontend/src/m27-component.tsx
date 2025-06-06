import React from "react";

interface Props {
   name: string;
}

const M27Component = (props: Props) => {
   return (
      <div>
         Hello {props.name}
      </div>
   );
}

export default M27Component;