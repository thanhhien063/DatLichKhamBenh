<!DOCTYPE html PUBLIC "#">
<html>

<head>
    <meta HTTP-EQUIV="REFRESH" content="0; url=contact-confirmation.html">

</head>

<body>
    <?php

		$name=$_POST['name'];
		$phone=$_POST['phone'];
		$Email=$_POST['email'];
		$subject=$_POST['subject'];
		$message=$_POST['message'];

		    
		    $body .= "Name: " . $name . "\n"; 
		    $body .= "Phone: " . $phone . "\n"; 
		    $body .= "Email: " . $Email . "\n"; 
		    $body .= "Subject: " . $subject . "\n"; 
		    $body .= "Message: " . $message . "\n"; 

		    //replace with your email
		    mail("demo@yourmail.com","New email",$body); 

		  
		?>

</body>

</html>
