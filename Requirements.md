# <i>Requirements Doc</i>

# Project Summary
This project is a way for users to share information that they want to with other users. Each user can submit their own ideas with step by step instructions and photos on how to do said thing. Users can also message the OP to get clarification if they don't understand a step, they can also search posts based on project title or tags that the OP used when making their post. Admin will approve posts and if anything is off they will mark it as a "needs to be revised" before it gets posted to the public.

# Models
<table class="table">
  <thead>
    <tr>
      <th scope="col">Model</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <th scope="row">User</th>
      <td>int ID</td>
      <td>string User Email</td>
      <td>string User screen name</td>
      <td>string User Posts</td>
      <td>list User Favorites </td>
      <td>list User Messages </td>
      <td>list User Notifications </td>
      <td>list AdminWarning </td>
    </tr>
    <tr>
      <th scope="row">Admin</th>
      <td>int ID</td>
      <td>string Admin Email</td>
      <td>string Admin screen name</td>
      <td>string Admin Posts</td>
      <td>list Admin Favorites </td>
      <td>list Admin Messages </td>
      <td>list Admin Notifications </td>
      <td>list Post Queue</td>      
    </tr>
    <tr>
      <th scope="row">Favorites</th>
      <td>int ID</td>
      <td>string user Email</td>
      <td>bool userFav</td>    
    </tr>
    <tr>
      <th scope="row">Messages</th>
      <td>int ID</td>
      <td>string User Email</td>
      <td>string Recipient Email</td>
      <td>string text body</td>   
    </tr>
    <tr>
      <th scope="row">Notifications</th>
      <td>int ID</td>
      <td>string User Email</td>
      <td>bool isUrgent</td>  
      <td>string notification text</td>
    </tr>
    <tr>
      <th scope="row">PostQueue</th>
      <td>int ID</td>
      <td>string Author Email</td>
      <td>string post body</td>
    </tr>
    
  </tbody>
</table>

# Admin
<ul>
    <li>Admin must approve a post before it is published</li>
    <li>Admin should be able to access posts by any user and delete or "hide" post if it is deemed offensive/dangerous and give user a chance to fix it</li>
</ul>

# User
<ul>
    <li>Users should be able to log in and have access to links to create, edit, and delete a post</li>
    <li>When making a new post users should be able to click "add body" button to create a new text box</li>
    <li>Users should be able to include images into post so that it shows in their post when submitted</li>
    <li>Users should be able to search for a post based on tags that the post creator entered or post title</li>
    <li>Users should be able to export an entry as a PDF to Google Drive through use of an API</li>
    <li>Users should be able to direct message another user if they have a question about any portion of a post and be notified when they recieve a message back</li>
    <li>If users post is flagged should get a warning and told they need to update their post</li>
</ul>

# Link to Google doc API
https://developers.google.com/drive/api/v3/quickstart/dotnet
