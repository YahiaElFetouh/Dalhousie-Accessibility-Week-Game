-> TeachersHome

=== TeachersHome ===
Gloria: Emily are you ready for school?
Emily: Yes mom I’ve got everything I need.
Gloria: Alright can you make your way to the school bus? I’m running late for work.
Emily: No worries, I can make it there. Have a good day at work mom. Love you!
Gloria: Alright thanks honey, love you too. Have a good day at school.
-> TeachersCar

=== TeachersCar ===
Gloria: I hope Emily has an easier time with fractions soon, I might have to…
Gloria has found themselves in a situation in which will change their day-to-day life for ever. Gloria found themselves in pain after the accident and finally visits a walk in clinic due to their busy schedule.
-> DoctorsRoom1

=== DoctorsRoom1 ===
Gloria: Hi Doctor, even though it’s been a while after the accident I still have pain within my neck.
Marsha: Alright, I’ll do a check up and see what I can find.
Marsha: Well I can’t find anything wrong with you. Was there anything else you were experiencing?
Gloria: The pain can come in waves, other days it hurts throughout the whole day. I’ve been losing sleep throughout the night and have trouble making my way around the house.
Marsha: Hunh, well there’s nothing more I can do for you. Take some Tylenol and see if it goes away.
Gloria: I’ve tried, and it isn’t enough. I’m worried this is something more serious.
Marsha: Well, like I said there’s nothing more I can do for you. You could try finding someone else if you’d like.
-> TeachersHouse

=== TeachersHouse ===
Gloria: I guess I could try and see a specialist, although I’m not sure I can book the time off between work and Emily. It took me long enough to go into the clinic.
    + Reach out to a specialist 
        -> PositiveEnding
    + Ignore symptoms, continue on to work
        -> NegativeEnding


= PositiveEnding 
Glenn: Hi Gloria, your file here says you’ve been having pain for the past 3 months due to a car accident. Could you tell me what symptoms you’re experiencing.
Gloria: Yes, since the accident I’ve had severe pain that sometimes comes in waves, other days it’s constant and near unbearable. I’ve been struggling sleeping much at night and I’ve had trouble getting around the house.
Glenn: Alright Gloria, I want you to know that you’re not alone in this. It sounds like you’re exhibiting symptoms of chronic pain. This can occur due to events much like yours. Since you’ve been experienced these symptoms for this long we can begin with mediation techniques however I would like to inform you that this may not go away.
Gloria: Thank you for taking this seriously. I feel as if there’s no one I can talk to about this and most people I do try don’t believe me. What options are available?
Glenn: Well we can begin with medication, we’ll start with standard anti-inflammatory acetaminophen. Take this sparingly as too much can cause problems. If required we can move to more advanced options such as; hydromorphone, morphine, etc. I’ll also provide you with some contact information for support groups for those with and family members affected by chronic pain. With these options you may not be fully cured however will have mediation strategies and learn to live with your condition.
Gloria: Thank you doctor, I’m just looking for a way to continue and learn how to mediate my symptoms.
-> InformationAndEnding

= InformationAndEnding
Having the need to be prescribed opioids by the chronic pain specialist Gloria was diagnosed officially with chronic pain. Gloria contacted support groups in which they were able to talk with others similar to themselves and discuss techniques they use to mediate their symptoms.
-> TeachersHomeEnding

= NegativeEnding
Gloria: Alright everyone, as mentioned in the previous lecture your assignment will …
Gloria: …your assignment will be…
Gloria: …will be due on…
As Gloria listened to the walk in clinic doctor and tried to ignore their symptoms, they’ve feinted. After a rest at the schools infirmary Gloria is on their lunch break with their colleagues.
-> LunchRoom

= LunchRoom
Joseph: Hey Gloria, I heard what happened during your lecture earlier. Are you ok?
Gloria: Oh, since the accident I’ve had bad pain in my neck and have had trouble sleeping.
George: That little fender bender you had a little bit ago? Surely it couldn’t be that bad.
Julie: Hey this could be something serious, I had a family member have something similar happen to them. Gloria have you considered talking to HR about getting disability insurance and seeing a specialist?
Gloria: It’s not something I’ve given too much thought about. Between work and Emily I’m not sure I could take much time off work to deal with it.
George: Well, if you’ve got the liberty to consider it you should be fine. Just pop back some Aspirin, that’ll fix it up.
    + Reach out to HR
        -> PositiveEnding2
    + Ignore symptoms, continue on to work
        -> NegativeEnding2
        
= NegativeEnding2
Due to external pressure Gloria chooses to continue ignoring the symptoms of their condition. 19 % of Canadians suffer from chronic pain. Some like Gloria can’t get the help that they deserve. If you or a loved one are experiencing symptoms of chronic pain, reach out. You can contact your primary care doctor, chronic pain specialists and support groups. Chronic pain is identified as a disability in Canada and does qualify for insurance. Due to the non-visible nature of chronic pain the system is difficult to manage, although with this effort you can find mediation techniques to live with chronic pain.
->END

= PositiveEnding2
Sonya: Good afternoon Gloria, your file says you’re here to apply for disability insurance for a case of.... Chronic pain?
Gloria: Yes, the symptoms aren’t easing up. This has been going on for too long and it’s time for me to take action.
Sonya: Alright, I’ll let you know others have come through for something similar and have struggled with the process. Are you sure this is something you want to go through with?
Gloria: ...I didn’t figure it should be harder than anyone else applying. Between work and Emily I’m not sure I’ll have the time...
Sonya: How about you head home and take some time to think about it?
    + Continue with insurance
        -> PositiveEnding3
    + Ignore symptoms
        -> NegativeEnding2
    
= PositiveEnding3
Gloria had decided to continue with the insurance process. The insurance company told Gloria to go see a doctor from their choosing.
Henry: So Gloria, your file here says you’ve been experiencing symptoms of chronic pain. Is this something you’ve been diagnosed by another doctor for?
Gloria: I have seen another doctor although they didn’t diagnose me with chronic pain. They told me to take Tylenol and sent me on my way.
Henry: So what you’re telling me is that this is self-diagnosed? What makes you think you think that?
Gloria: Well from the research I’ve done it’s been about 3 months since the accident and the pain isn't letting up at all. Even the other day during one of my classes I had feinted. I’m here because I think this is something serious.
Henry: Well, I’ll perform an examination and see if I find anything.
Henry: Well Gloria, the results show no physical damage that would result in these symptoms that you’re describing. As a result there’s nothing I can do for your insurance application.
Gloria: I don’t understand, do you not believe me? Is there anything else I can do?
Henry: I'm afraid there’s nothing else I can do, you’re entitled to a second opinion and could try and find a specialist if you’d like.
Gloria: ...Okay, I’ll have to think about it.
    + Seek out specialist for second opinion
        -> PositiveEnding4
    + Ignore symptoms
        -> NegativeEnding2

= PositiveEnding4
Glenn: Hi Gloria, your file here says you’ve been having pain for the past 3 months due to a car accident. Could you tell me what symptoms you’re experiencing.
Gloria: Yes, since the accident I’ve had severe pain that sometimes comes in waves, other days it’s constant and near unbearable. I’ve been struggling sleeping much at night and I’ve had trouble getting around the house.
Glenn: Alright Gloria, I want you to know that you’re not alone in this. It sounds like you’re exhibiting symptoms of chronic pain. This can occur due to events much like yours. Since you’ve been experienced these symptoms for this long we can begin with mediation techniques however I would like to inform you that this may not go away.
Gloria: Thank you for taking this seriously. I feel as if there’s no one I can talk to about this and most people I do try don’t believe me. What options are available?
Glenn: Well we can begin with medication, we’ll start with standard anti-inflammatory acetaminophen. Take this sparingly as too much can cause problems. If required we can move to more advanced options such as; hydromorphone, morphine, etc. I’ll also provide you with some contact information for support groups for those with and family members affected by chronic pain. With these options you may not be fully cured however will have mediation strategies and learn to live with your condition.
Gloria: Thank you doctor, I’m just looking for a way to continue and learn how to mediate my symptoms.
->InformationAndEnding 

= TeachersHomeEnding
Emily: Hey mom, how did that meeting with that lady from work? Are they going to be able to help you?
Gloria: Well honey, they gave me a choice. I could ...
Emily: Well mum I’ve got faith in you and I’m here for you.
-> END