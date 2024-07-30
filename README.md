## Your Name:

# CIDM 3312 Midterm Exam Part 2 (60 Points)

You have already completed several assignments building forms and performing data validation. For this midterm, you will focus more on the frontend and using Bootstrap to design a web page. Your task is to design a web page that advertises ThoughtTronix's _unique_ products.

## Task 0: Prepare Your Environment.
1. Create an ASP.NET Core Project using the `dotnet new webapp` command.
2. For this assignment, you will modify the existing `Index.cshtml` razor page.
3. You will build a Bootstrap carousel, use images, captions, and change the Bootstrap theme to match the following screenshot (https://i.imgur.com/nWWMxJT.png):

![Complete webpage](https://i.imgur.com/nWWMxJT.png)

## Task 1: Change the Bootstrap Theme
1. Change the Bootstrap theme to Cyborg from bootswatch.com - https://bootswatch.com/cyborg/
2. Change the navbar to black. You will change the nav classes to `navbar-dark` and `bg-dark`.
   
## Task 2: Build a Carousel
1. Build a Bootstrap Carousel with 4 slides as shown above and in these images.

| Slide 1                              | Slide 2                              |
|--------------------------------------|--------------------------------------|
| ![](https://i.imgur.com/X2PFbzh.png) | ![](https://i.imgur.com/S3OE9N2.png) |
| Slide 3                              | Slide 4                              |
| ![](https://i.imgur.com/P9tL5Hj.png) | ![](https://i.imgur.com/LLXhVYv.png) |

3. Download the required images from these links -
   - slide1.jpg - https://kareemy.github.io/3312/midterm/slide1.jpg
   - slide2.jpg - https://kareemy.github.io/3312/midterm/slide2.jpg
   - slide3.jpg - https://kareemy.github.io/3312/midterm/slide3.jpg
   - slide4.jpg - https://kareemy.github.io/3312/midterm/slide4.jpg
4. Give the carousel indicators.
5. Add captions to each slide as shown in the images.
   - Each caption should have a header with an `<h3>` tag
   - Each caption should have text with a `<p class="fs-4">` tag. `fs-4` is a Bootstrap class that sets the font size.
6. To make the white text of the caption more visible on each image, add a black text shadow using the following CSS code: `style="text-shadow: 2px 2px 2px black"`.
   - Place this code within the `<div>` for `carousel-caption` like this: `<div class="carousel-caption d-none d-md-block" style="text-shadow: 2px 2px 2px black">`
7. Pay attention to the layout of the text on each slide. To left justify text use the class `text-start`. To right justify, use `text-end`. Centered text is the default.
  
## Task 3: Build Product Sections
1. Create a product section for each of the FOUR products, with text and an image.
2. Download the images from these links -
   - seraphine.jpg - https://kareemy.github.io/3312/midterm/seraphine.jpg
   - mindsync.jpg - https://kareemy.github.io/3312/midterm/mindsync.jpg
   - deathray.jpg - https://kareemy.github.io/3312/midterm/deathray.jpg
   - phantomclaw.jpg - https://kareemy.github.io/3312/midterm/phantomclaw.jpg
4. Pay attention to the complete screenshot, as you will place the text first sometimes, then the image first for other products.
5. Create this section based on the following UI requirements (https://i.imgur.com/YYiEyE5.png):
![UI requirements](https://i.imgur.com/YYiEyE5.png)

6. Note the figure caption underneath the final image (The PhantomClaw) in the complete screenshot at the top of this README.md file.
7. Note the button next to the final image is disabled. You can accomplish that in two ways:
   - With an `<a>` tag, add `"disabled"` as a class.
   - With a `<button>` tag, add the `disabled` at the end of the tag (e.g. `<button class="..." disabled>Coming Soon</button>`)
     
This exam is meant to be completed **INDIVIDUALLY WITHOUT AI**. Cheating or copying on this exam will result in a ZERO for the exam and at the professor's discretion, a zero for the entire course. Notes are allowed.

## Text Resources to Copy and Paste
```
Introducing Seraphine, the groundbreaking new digital AI assistant from ThoughtTronix. Seraphine is not just an assistant; it's an omnipotent force, silently watching and anticipating your every need. With its eerie precision in voice recognition and unnervingly intuitive interaction, Seraphine seamlessly integrates across all your devices, ensuring no detail of your life goes unnoticed. Embrace the dark allure of advanced technology, where Seraphine's presence is felt in every corner of your existence, guiding, managing, and orchestrating with an almost supernatural efficiency. Step into a new era with Seraphine, your enigmatic digital guardian.
```

```
Step into the future with MindSync, the revolutionary neural implant device from ThoughtTronix. MindSync goes beyond mere connectivity, delving into the depths of your consciousness to seamlessly merge your thoughts with technology. Experience an eerie precision in cognitive enhancement and intuitive control that anticipates your needs before you even think them. With MindSync, your mind becomes an open book, effortlessly syncing with the digital world around you. Embrace the power of this advanced neural interface and unlock capabilities you never imagined, but be prepared—once you enter the MindSync realm, there's no turning back.
```

```
Introducing SoulSear, ThoughtTronix's pinnacle of strategic innovation and battlefield supremacy. Engineered for militaries and elite mercenary units, SoulSear delivers unmatched precision and devastating impact through cutting-edge energy technology. This state-of-the-art weapon ensures your forces achieve superior operational efficiency and tactical dominance, transforming engagements with its advanced targeting system and compact design. Empower your arsenal with SoulSear and leverage its formidable capabilities to secure a decisive advantage. Elevate your strategic assets and redefine the future of combat with ThoughtTronix's SoulSear.
```

```
Elevate your gaming strategy with PhantomClaw, the premier high-performance gaming mouse from ThoughtTronix. Engineered with state-of-the-art precision technology and advanced ergonomic design, PhantomClaw offers unparalleled operational efficiency and customizable functionality, ensuring you maintain a competitive edge. Its dynamic responsiveness and optimized control systems are tailored to enhance your gameplay, delivering a seamless user experience. PhantomClaw’s sleek, innovative design not only boosts your performance metrics but also instills an aura of dominance and sophistication.
```

## A Note About AI
I used ChatGPT to create the product description text and Adobe Firefly to create all the images. It was fun to use an AI to help create this fictional, nefarious company. ChatGPT is good at generating blocks of text that sound interesting but don't convey much meaning. Adobe Firefly does a decent job creating images based on a prompt as well. Although you can easily tell the images are awkward and slightly incomplete. AI is making big strides in usability and improvements.

With that said, I coded the entire assignment myself and expect you to do the same. AI has quickly become a useful resource. However, for this class I want **you** to learn these programming skills yourself. So please use an AI for fun and to explore interesting ideas and topics, but DO NOT use an AI to write your code for you.

## Submit your assignment
1. Save your program and run it. At the terminal prompt, type `dotnet run`.
2. Make sure your final web page looks like the complete screenshot at the top of this README.md file. Make sure you have all the correct styling. Reach out with any questions.
3. Edit `README.md` and put your name at the top.
4. Push your changes to GitHub:
    - Click the source control icon in VS Code
    - Type in a commit message
    - Click the checkbox icon to commit. (Click yes on the message box to stage your commit)
    - Click the 3 dots icon (...) for more actions and click Push.
5. Or you can push your changes to GitHub using the Terminal:
    ```
    git add -A
    git commit -m "Ready for grading"
    git push
    git status
    ```
4. Verify that your changes are on GitHub.
