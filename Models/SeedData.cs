using Microsoft.EntityFrameworkCore;

namespace TheFinal_jacalva.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());

        if (context.Studios.Any())
        {
            return;
        }

        // Add Studios, Games, and StudioGames below
        List<Studio> studios = new List<Studio>
        {
            new Studio 
            { 
            StudioName = "Obsidian Realm Studios",  
            acquisitionyear = 2014 
            },
            
            new Studio 
            {
            StudioName = "RuneBlade Entertainment",  
            acquisitionyear = 2010
            },

            new Studio 
            {
            StudioName = "NightShade Interactive",  
            acquisitionyear = 2018
            }
        };
        context.AddRange(studios);
        context.SaveChanges();

        List<Game> games = new List<Game>

        {
        new Game 
        {
            GameTitle = "Quantum Rift", 
            CopiesSold = 10890, 
            Rating = 2,
            YearReleased = 2018, 
            ImageURL = "img/Quantum.png", 
            Description = "In Quantum Rift, players step into the role of a starship captain navigating through the fabric of reality itself. A powerful rift in space has opened, threatening to tear apart entire galaxies, and only those with the most advanced technology can survive its chaotic waves. As you traverse the rift, you'll face cosmic anomalies, hostile alien species, and rival factions determined to control the power within. Utilizing cutting-edge weapons and quantum manipulation, your mission is to restore balance to the universe before time itself unravels. The game blends fast-paced space combat with elements of time travel and dimensional exploration, creating a thrilling and unpredictable journey through space's darkest corners. Will you be able to seal the rift, or will it consume everything you hold dear?"
        },
         
        
        new Game 
        {
            GameTitle = "Nebula's Edge",
            CopiesSold = 32400,
            Rating = 5,
            YearReleased = 2016,
            ImageURL = "img/Nebula.png",
            Description = "Set in the distant future, Nebula’s Edge follows a group of elite space mercenaries hired to explore the edge of the known universe. A once-peaceful region of space has become a battlefield for ancient alien relics, and the crew must battle rival factions, rogue AIs, and mythical creatures that exist in the nebulous clouds. The game combines intense space dogfights with on-foot action sequences, as players uncover hidden secrets and powerful artifacts that could change the fate of the galaxy. As the line between friend and foe blurs, your team must make difficult choices that could either unite or destroy civilizations. In this high-stakes adventure, futuristic technology and mythical forces collide, pushing the boundaries of what’s possible in both space and time. Will you be the hero the galaxy needs, or succumb to the chaos of the nebula?"
        },
   
        new Game 
        {
            GameTitle = "Zero Hour: Collapse",
            CopiesSold = 20320,
            Rating = 3,
            YearReleased = 2017,
            ImageURL = "img/Zero.png",
            Description = "In Zero Hour: Collapse, a cataclysmic event threatens to collapse the entire intergalactic empire. As the last remaining soldier of a fallen space station, you must fight your way through a universe in turmoil, where the once-glorious human empire has fractured into warring factions. The game combines intense tactical space combat with fast-paced action as you try to stop a rogue AI from triggering the galaxy-wide collapse. Players will battle through ruined cities, derelict space stations, and hostile alien planets, all while upgrading their gear and unraveling the mysteries behind the catastrophic event. Futuristic weapons and magical artifacts from forgotten realms offer new ways to defeat enemies and manipulate time itself. The fate of the galaxy rests on your shoulders—will you avert total destruction or be the spark that ignites it?",
            
        },
    
        
        new Game 
        {
            GameTitle = "Enigma Protocol",
            CopiesSold = 36230,
            Rating = 4,
            YearReleased = 2014,
            ImageURL = "img/Enigma.png",
            Description = "Enigma Protocol is a thrilling, action-packed adventure where players become operatives of a secret organization tasked with uncovering an ancient alien conspiracy hidden deep within the stars. Set in a distant future, the game blends advanced technology with a touch of magic as you investigate mysterious artifacts, decode cryptic messages, and engage in high-stakes missions across space. The fate of multiple star systems hangs in the balance as you encounter alien races, forgotten gods, and powerful forces that manipulate the very fabric of reality. Players must navigate treacherous environments, solve complex puzzles, and battle enemies wielding both futuristic weapons and mystical powers. Every decision you make shapes the outcome, leading to multiple endings where the secrets of the universe either remain hidden or are revealed. Can you uncover the Enigma Protocol before it's too late?",
            
        },

        new Game 
        {
            GameTitle = "Shattered Realms",
            CopiesSold = 15860,
            Rating = 2,
            YearReleased = 2017,
            ImageURL = "img/Shattered.png",
            Description = "Shattered Realms is a futuristic fantasy game set in a universe where the very fabric of reality has fractured, creating a labyrinth of alternate dimensions. Players take on the role of a 'realmbreaker,' an elite warrior capable of traversing between worlds and combating creatures that defy the laws of physics. The game’s rich narrative weaves together cosmic battles, ancient magic, and advanced technology, as players fight to prevent the realms from collapsing into chaos. In Shattered Realms, space travel is not limited to traditional ships—players can leap through portals, manipulating the very fabric of reality to alter time, space, and fate. Along the way, you’ll encounter rival factions, mythical creatures, and long-lost civilizations all vying for control of the shattered multiverse. Will you restore balance to the realms, or will they fall into eternal ruin?",
            
        },
        

        new Game 
        {
            GameTitle = "Sons of the Fallen Star",
            CopiesSold = 24340,
            Rating = 4,
            YearReleased = 2018,
            ImageURL = "img/Sons.png",
            Description = "Sons of the Fallen Star thrusts players into a galactic war spanning centuries, where the fate of the galaxy rests in the hands of a once-exiled royal family. The empire of the stars has crumbled, leaving countless planets in ruins, and only the sons and daughters of the fallen monarchs hold the secret to restoring balance. As the scion of the royal bloodline, you must rally fractured factions, uncover long-forgotten technology, and confront ancient, otherworldly forces. The game combines brutal space battles, political intrigue, and powerful, mystical artifacts to challenge players to redefine their destiny. With your ability to wield both advanced weaponry and celestial magic, you must decide whether to rebuild the galaxy's empire or let it burn in the ashes of its past. Will you rise from the shadows and reclaim your birthright, or will the galaxy fall into eternal darkness?",
        },
        

        new Game 
        {
            GameTitle = "Horizon Breaker",
            CopiesSold = 30970,
            Rating = 5,
            YearReleased = 2016,
            ImageURL = "img/Horizon.png",
            Description = "In Horizon Breaker, you are a rebel leader battling against a dystopian future where the last remnants of humanity are trapped within a vast city encased by a mysterious energy barrier. As the leader of a group of freedom fighters, you must venture beyond the city's limits to uncover the truth behind the barrier and the cosmic forces controlling it. Futuristic technology meets ancient magic in a world filled with dangerous creatures, ruthless governments, and ancient ruins hiding powerful secrets. With a customizable arsenal of weapons, exosuits, and mythical abilities, you'll face off against enemies in explosive ground and space combat. Along the way, the line between friend and foe blurs, and the future of humanity may rest on your ability to unlock the mysteries of the horizon. Will you break free from the city’s suffocating grip or succumb to the powers that seek to control your destiny?",
        },
        

        new Game 
        {
            GameTitle = "Spectral Blade",
            CopiesSold = 27560,
            Rating = 4,
            YearReleased = 2017,
            ImageURL = "img/Spectral.png",
            Description = "Spectral Blade is a dark and thrilling action-adventure set in a universe where the dead are brought back to life through mysterious, ancient technology. You play as a spectral warrior, a soul-bound hero tasked with hunting down corrupted spirits who threaten to tear apart both the living and the dead. The game blends fast-paced sword combat with otherworldly powers that allow players to manipulate the ethereal realm, shifting between the physical and spiritual planes. As you fight through ruined space stations, haunted starships, and ancient temples, you uncover a dark conspiracy involving a forbidden alliance between alien races and forbidden magic. With every enemy slain, you absorb their powers and grow stronger, but the price of such power is high—how much of your humanity will you sacrifice to restore peace to the galaxy? The fate of the living and the dead hangs in the balance, and only the most powerful Spectral Blades can save both realms.",
            
        },
        

        new Game 
        {
            GameTitle = "Legends of the Arcane Realm",
            CopiesSold = 22360,
            Rating = 3,
            YearReleased = 2020,
            ImageURL = "img/Legends.png",
            Description = "Legends of the Arcane Realm invites players into a fantastical universe where magic and technology coexist, and ancient gods walk among mortals. In this story-driven adventure, you become a legendary hero chosen to protect the Arcane Realm from an all-consuming darkness that threatens to shatter the fabric of reality. Using both futuristic gadgets and enchanted relics, you explore vast, mystical lands teeming with mythical creatures, hidden temples, and powerful wizards. The game blends high-octane space battles with tactical fantasy combat, as you journey to uncover the ancient secrets of the Arcane Realm’s origin. Along the way, you’ll forge alliances with rival factions, solve complex riddles, and battle enemies wielding both technology and forbidden magic. As the power struggle intensifies, you must decide whether to embrace the ancient gods’ power or seek a new path to save the realms from total annihilation.",
            
        },


        new Game 
        {
            GameTitle = "Stellar Genesis",
            CopiesSold = 32430,
            Rating = 5,
            YearReleased = 2016,
            ImageURL = "img/Stellar.png",
            Description = "In Stellar Genesis, players are thrust into the role of a cosmic architect, a being capable of shaping entire star systems and creating new worlds from the fabric of space itself. A cataclysmic event has fractured the galaxy, and you are one of the last survivors of an ancient Game tasked with rebuilding civilization across the stars. Using a combination of advanced engineering and primordial magic, you must terraform barren planets, construct space stations, and forge alliances with alien species. But not all are friendly—hostile forces seek to harness your power for their own dark purposes, and you’ll need to defend your creations from relentless invaders. As you journey across the galaxy, you’ll uncover the forgotten mysteries of the universe’s creation and unlock the secrets of the Stellar Genesis. Will you restore balance to the galaxy, or will your creations be destroyed by the very forces you seek to control?",
        },
        

        //RuneBlade Entertainment Top 10--------------------------------------------

        new Game 
        {
            GameTitle = "Planetfall: Rebirth",
            CopiesSold = 22320,
            Rating = 4,
            YearReleased = 2016,
            ImageURL = "img/Planetfall.png",
            Description = "In Planetfall: Rebirth, players are thrust into a medieval-fantasy world that has been reshaped by a cataclysmic cosmic event. What was once a technologically advanced kingdom has regressed to a dark age, where magic and steel reign supreme. You play as a warlord leading a ragtag army of survivors against an oppressive empire seeking to harness both ancient sorcery and forgotten technology. As you explore ruined cities and battle monstrous creatures, you must unite fragmented kingdoms and reclaim the lost knowledge of the stars. The game blends fierce medieval combat with mystical abilities, as you engage in large-scale battles, siege warfare, and strategic decisions. Your choices will determine the rebirth of the world—will you restore the old empire or create something entirely new?",
        },
        
        
        new Game 
        {
            GameTitle = "Thunderstrike: Rebellion",
            CopiesSold = 19890,
            Rating = 3,
            YearReleased = 2018,
            ImageURL = "img/Thunderstrike.png",
            Description = "In Thunderstrike: Rebellion, the kingdom of Eldaroth is on the brink of collapse as a cruel and tyrannical ruler unleashes an iron fist across the lands. You lead a rebellious faction of knights, rogues, and mages, united by a common cause: overthrowing the king’s reign and reclaiming the freedom of the people. The game features high-intensity action, where you must face off against powerful royal armies, mythical beasts, and magical forces in both close combat and long-range battles. With each victory, you unlock powerful abilities and legendary weapons from the kingdom’s ancient past. As you gather allies and resources, you’ll face moral choices that will shape the fate of Eldaroth—will you seek vengeance or try to build a new kingdom based on justice and honor? The thunder of rebellion is in your hands.",
        },

        new Game 
        {
            GameTitle = "Rogue Battalion",
            CopiesSold = 13050,
            Rating = 1,
            YearReleased = 2020,
            ImageURL = "img/Rogue.png",
            Description = "Rogue Battalion places you in the shoes of a rogue captain who leads a band of misfit soldiers in an epic war for survival. In a land where medieval kingdoms are locked in an unending war, you must navigate treacherous battlefields, gather resources, and recruit deserters from both sides of the conflict. The game focuses on tactical combat and guerilla warfare, where the odds are stacked against you, and only strategic thinking can ensure victory. Players will engage in intense skirmishes, from ambushes in forests to siege battles on castle walls, all while dealing with the complexities of loyalty, betrayal, and the harsh realities of war. Along the way, you’ll unlock ancient war magic and forge alliances with mythical creatures to tip the scales in your favor. The fate of your battalion—and perhaps the entire realm—rests on your ability to lead and survive.",
        },

        new Game 
        {
            GameTitle = "Rise of the Fallen Warrior",
            CopiesSold = 14400,
            Rating = 3,
            YearReleased = 2019,
            ImageURL = "img/Rise.png",
            Description = "In Rise of the Fallen Warrior, you take on the role of a once-legendary knight who has been betrayed and left to die on a forgotten battlefield. However, the gods have given you a second chance—now risen from the dead, you must seek vengeance against those who destroyed you while uncovering the truth behind the dark magic that cursed your land. As you journey through haunted forests, cursed villages, and ancient fortresses, you’ll encounter allies in the form of enchanted beasts and old comrades, each with their own agendas. The game features brutal, fast-paced combat and magical powers that grow stronger as you restore your honor. As the story unfolds, you’ll face moral dilemmas—will you seek vengeance at any cost or redeem yourself by becoming the hero the kingdom needs? The land’s fate depends on whether you can rise above the darkness of your past.",
        },

        new Game 
        {
            GameTitle = "Fury: The Last Stand",
            CopiesSold = 21490,
            Rating = 4,
            YearReleased = 2018,
            ImageURL = "img/Fury.png",
            Description = "In Fury: The Last Stand, players are thrust into the heart of a dying kingdom on the brink of destruction. The once-mighty kingdom of Valoria has been overrun by an unstoppable enemy, and you are the last of its royal guard, standing in the way of total annihilation. Armed with legendary weapons and empowered by ancient magic, you must lead a final, desperate stand against a force that threatens to wipe out everything you’ve fought for. The game is filled with fast-paced, brutal combat as you defend the last stronghold, wielding swords, bows, and powerful elemental spells against monstrous enemies and dark sorcerers. Along the way, you’ll encounter mythical beings, including dragons and gods, who will either aid or hinder your mission. The battle for survival is your last chance to save your kingdom from oblivion—will you stand tall, or will Valoria fall?",
        },

        new Game 
        {
            GameTitle = "Blitzkrieg Legacy",
            CopiesSold = 26200,
            Rating = 5,
            YearReleased = 2020,
            ImageURL = "img/Blitz.png",
            Description = "In Blitzkrieg Legacy, players find themselves in a war-torn medieval world where the remnants of ancient armies are resurrected through dark sorcery. The game focuses on large-scale warfare, where you must lead your battalion of knights, archers, and war mages against enemy forces using strategic tactics and brutal combat. As you navigate the battlefield, you'll command siege engines, deploy devastating magical attacks, and even summon legendary war beasts from ancient times. Amidst the chaos, you uncover the truth behind the sorcery that is reviving the dead and threatening to unbalance the entire realm. Each victory brings you closer to unraveling the dark legacy that binds the warring factions. Will you protect the kingdom's honor, or become part of the endless cycle of war?",
        },

        new Game 
        {
            GameTitle = "Warborn Legends",
            CopiesSold = 11980,
            Rating = 1,
            YearReleased = 2019,
            ImageURL = "img/Warborn.png",
            Description = "In Warborn Legends, the fate of the kingdoms is determined by the might of legendary warriors who have been chosen by the gods themselves. Set in a medieval fantasy world on the brink of destruction, you play as one of these chosen heroes, bound by prophecy to lead your people to victory against a dark, encroaching force. With each warborn hero comes unique powers, legendary weapons, and the ability to call upon divine magic to turn the tide of battle. As you lead your armies across vast, war-ravaged lands, you’ll forge alliances, conquer rival kingdoms, and fight alongside mythical creatures like griffins and golems. The legends of the old gods whisper in your ears, guiding you toward a final confrontation with the evil that threatens to erase the world. Will you rise to become a true legend, or will the kingdom fall under the shadow of darkness?",
        },

        new Game 
        {
            GameTitle = "Ironclad Heroes",
            CopiesSold = 20300,
            Rating = 4,
            YearReleased = 2017,
            ImageURL = "img/Ironclad.png",
            Description = "Ironclad Heroes thrusts you into a medieval world where legendary knights, clad in indestructible iron armor, battle against monstrous forces in a war to reclaim the kingdom from an ancient evil. The game’s action-packed combat allows you to wield massive, enchanted weapons while riding armored warhorses into epic battles. As the leader of an elite Game known as the Ironclad, you must unite fractured kingdoms, liberate oppressed villages, and break the siege of an all-powerful sorcerer. With customizable armor, legendary relics, and powerful combat spells, each hero in your Game will play a vital role in the war effort. As you advance, the line between technology and magic begins to blur, and you’ll face increasingly formidable enemies who wield the same Ironclad technology for darker purposes. The fate of the realm rests in your hands as you fight to protect the kingdom—and its very soul—from annihilation.",
            
       },

        new Game 
        {
            GameTitle = "Kingdoms of Ruin",
            CopiesSold = 28820,
            Rating = 5,
            YearReleased = 2016,
            ImageURL = "img/Kingdoms.png",
            Description = "In Kingdoms of Ruin, the once-glorious kingdoms of the world have fallen to ruin, ravaged by the destructive power of dragons and dark sorcery. The player assumes the role of a royal heir who must reclaim their birthright and restore their fallen kingdom to its former glory. The game’s vast landscapes are filled with the ashes of ruined castles, while ancient dragons, once guardians of peace, now threaten all life with their fiery wrath. As you lead armies of knights and mages, you will discover powerful dragon lore that can either be used to defeat or control these mythical beasts. With the help of legendary dragon slayers and magic-wielding allies, you must embark on a perilous journey to defeat a dark sorcerer who has enslaved the dragons. The line between friend and foe is uncertain as ancient secrets rise from the ashes of the old kingdoms, and only a true heir can restore balance to a shattered world",
        },

        new Game 
        {
            GameTitle = "Wasteland Survivors",
            CopiesSold = 22480,
            Rating = 4,
            YearReleased = 2015,
            ImageURL = "img/Wasteland.png",
            Description = "In Wasteland Survivors, the kingdom has fallen, and all that remains is a desolate, war-torn landscape. As a survivor of the last great war, you lead a group of outcasts, bandits, and former soldiers who must navigate the dangerous remnants of medieval society in a world where every day is a struggle for survival. The game combines resource management, strategic warfare, and brutal combat as you raid enemy camps, build fortified settlements, and engage in desperate skirmishes against rival factions. Magic, long thought lost, resurfaces in the wasteland, granting hope to those brave enough to wield its power. Your survival depends on your ability to forge alliances with the remnants of old kingdoms, fight back against the warlords who now control the land, and uncover the ancient secrets that could either save or doom the survivors. In a land where only the strong survive, can you unite the fractured remnants of the kingdom—or will you perish in the wasteland's shadow?",
        },


        //NightShade Interactive Top 10-------------------------------------------------

        new Game 
        {
            GameTitle = "Wings of the Fallen",
            CopiesSold = 32450,
            Rating = 5,
            YearReleased = 2015,
            ImageURL = "img/Wings.png",
            Description = "In Wings of the Fallen, players are thrust into a grim world where death has broken the boundary between the living and the dead. As a fallen warrior, you are resurrected by an ancient, cursed force and granted spectral wings that give you both freedom and torment. The realm is teeming with grotesque monsters, vengeful spirits, and the remnants of those who have perished in horrific ways. Armed with cursed weapons and dark magic, you must navigate twisted landscapes filled with decaying forests, haunted castles, and graveyards that come alive with the dead. As you seek answers to your resurrection, you discover that you are part of an ancient prophecy and must face an evil that threatens to consume the living and the dead alike. But with each victory, your connection to the realm of the dead grows stronger, and the line between life and death begins to blur",
        },
        
        new Game 
        {
            GameTitle = "Nightmare's Reach",
            CopiesSold = 28350,
            Rating = 4,
            YearReleased = 2017,
            ImageURL = "img/Nightmare.png",
            Description = "In Nightmare's Reach, a once-prosperous kingdom has fallen under the grip of a malevolent force, turning it into a living nightmare. You play as a lone survivor, cursed to wander through a world where reality and terror are indistinguishable. The game is filled with grotesque, horrifying creatures that lurk in the shadows, including demonic spirits, monstrous nightmares, and twisted humans driven mad by the horrors surrounding them. As you venture deeper into the decaying ruins of the kingdom, you must face psychological and physical challenges, solving puzzles while battling nightmarish enemies that regenerate from death. Each victory takes you closer to understanding the curse that has taken hold of the land, but as you uncover the truth, you realize that you may be the last hope—or the final sacrifice—needed to stop an ancient evil from escaping the realm of nightmares. The line between dreams and death is fragile, and you must navigate this dangerous world before it consumes you entirely.",
        },

        new Game 
        {
            GameTitle = "Soul's Abyss",
            CopiesSold = 17450,
            Rating = 2,
            YearReleased = 2020,
            ImageURL = "img/Soul.png",
            Description = "Soul's Abyss is a dark, action-packed game that delves into the depths of the afterlife, where lost souls are trapped in an endless torment. Players control a tortured soul who is given a second chance to escape, but the price is steep—your body is forever gone, and you are bound to an ethereal existence. The Abyss is a nightmarish realm filled with horrifying specters, demonic entities, and powerful necromancers, all eager to drag you back into the darkness. To survive, you must battle through hellish landscapes, using dark magic and cursed weapons to fight enemies that grow stronger with each death. As you explore the depths of this twisted underworld, you'll uncover the tragic pasts of souls who have long been forgotten and face monstrous guardians who stand between you and your freedom. The longer you linger in the Abyss, the more you risk losing your humanity and becoming just another wretched spirit wandering in torment.",
        },

        new Game 
        {
            GameTitle = "Darkfall: Rise of the Undead",
            CopiesSold = 14980,
            Rating = 3,
            YearReleased = 2019,
            ImageURL = "img/Darkfall.png",
            Description = "In Darkfall: Rise of the Undead, the world is plunged into chaos as the dead rise from their graves, their flesh rotting but their hunger insatiable. A dark ritual has torn open the gates to the afterlife, releasing unspeakable horrors into the land, and the only hope lies with a group of outcasts who must battle their way through cities now overrun by undead horrors. You are one of the last survivors, equipped with cursed relics and weapons forged from the remains of fallen warriors. The game is a brutal mix of action, gore, and survival, where each encounter with the undead becomes increasingly grotesque and terrifying. As you uncover the secrets behind the undead uprising, you learn that the true enemy may not be the risen dead, but a dark sorcerer who controls them from the shadows. With the world on the brink of collapse, you must fight not only for survival but for the soul of humanity itself.",
        },

        new Game 
        {
            GameTitle = "The Hollow Man",
            CopiesSold = 11470,
            Rating = 1,
            YearReleased = 2016,
            ImageURL = "img/Hollow.png",
            Description = "The Hollow Man is a chilling, paranormal thriller set in a forgotten village where the dead do not rest and the living are trapped in a state of eternal dread. You play as a private investigator called to uncover the truth behind a series of mysterious disappearances, only to find yourself ensnared in a deadly cycle of horror. The villagers, once living, are now hollow shells of their former selves, controlled by dark spirits that feed on the living. As you unravel the mystery, you discover a cursed ritual that has awakened ancient, malevolent forces, including the terrifying Hollow Man—a specter who consumes the souls of those who enter the village. The game blends psychological horror, action, and dark fantasy as you fight off gory apparitions, solve intricate puzzles, and face the Hollow Man in a final confrontation. Your survival depends on uncovering the truth behind the curse before you become another lost soul in the village's horrifying legacy.",
        },

        new Game 
        {
            GameTitle = "Whispers in the Void",
            CopiesSold = 21340,
            Rating = 4,
            YearReleased = 2018,
            ImageURL = "img/Whispers.png",
            Description = "In Whispers in the Void, players step into a haunting world where an ancient evil lurks just beyond the edges of perception. You are a lone investigator sent to a remote town surrounded by a dark, endless void that seems to warp reality itself. As you venture deeper into the town, you begin to hear whispers—voices from the beyond that try to drive you mad. The townspeople are not what they seem, their bodies decaying and souls lost to an otherworldly force that feeds on their fear. As you unravel the twisted history of the town, you discover that the void itself is alive, a sentient entity feeding off the anguish and despair of those who enter its grasp. To escape, you must confront the entity’s horrifying manifestations and seal the rift before you, too, are lost to its unyielding darkness.",
        },

        new Game 
        {
            GameTitle = "Fear the Blackened Sky",
            CopiesSold = 16480,
            Rating = 2,
            YearReleased = 2017,
            ImageURL = "img/Fear.png",
            Description = "Fear the Blackened Sky throws players into a world where the skies themselves are a harbinger of death. A cataclysmic event has darkened the heavens, releasing vile, winged creatures that tear through the skies and descend upon the land, slaughtering anyone in their path. As one of the last remaining warriors, you must battle these monstrous beasts while uncovering the truth behind the cursed skies. The game features brutal combat, where every encounter is a fight for survival against overwhelming odds. Along the way, you’ll uncover the ancient prophecy that foretold the arrival of the creatures, discovering that the darkened sky is a symbol of a far more terrifying force—a malevolent god intent on reshaping the world. As the sky grows darker and the creatures multiply, you must decide whether to fight or succumb to the fear that clouds the heavens.",
        },

        new Game 
        {
            GameTitle = "Echoes of the Damned",
            CopiesSold = 18870,
            Rating = 3,
            YearReleased = 2019,
            ImageURL = "img/Echoes.png",
            Description = "In Echoes of the Damned, the echoes of past souls haunt the land, unable to rest due to a curse that traps them in the mortal realm. You are a cursed soul who has risen from the grave to investigate a sinister force that binds the dead to this world. Armed with spectral powers and bound to a body that rots away with each passing moment, you must battle terrifying apparitions, demonic entities, and twisted reanimations of the once-living. As you explore the haunted lands, you uncover fragments of memories that lead you to a dark ritual that has been invoked by a powerful necromancer. The deeper you venture, the more you question your own existence, as your soul becomes further entangled in the damned echoes of the past. Will you break the curse and escape the cycle of death, or will you be swallowed by the very echoes you seek to silence?",
        },

        new Game 
        {
            GameTitle = "Fate’s Requiem",
            CopiesSold = 25630,
            Rating = 5,
            YearReleased = 2016,
            ImageURL = "img/Fate.png",
            Description = "Fate’s Requiem follows the story of a fallen hero who has been resurrected in a land where death is not the end, but only the beginning of suffering. The world is plagued by an unholy curse that prevents the dead from resting, causing them to rise as twisted, vengeful versions of their former selves. As you awaken in this dark world, you must battle through hordes of undead, demonic entities, and cursed spirits that hunger for your soul. The game’s dark fantasy elements come to life as you uncover the truth behind your resurrection and the curse that binds the living and the dead. Along the way, you encounter powerful enemies and mythical beings, all while facing a dire decision: break the curse and restore the natural Game, or embrace your new fate and become an instrument of destruction. The requiem of fate has begun, and the price for redemption may be higher than you could ever imagine.",
        },

        new Game 
        {
            GameTitle = "The Asylum's Call",
            CopiesSold = 29990,
            Rating = 5,
            YearReleased = 2019,
            ImageURL = "img/Asylum.png",
            Description = "In The Asylum's Call, players are drawn into an abandoned asylum, where the very walls seem to whisper secrets of the dark, twisted experiments that took place there. Once a facility for the criminally insane, the asylum is now home to a host of terrifying entities—demented spirits, tortured souls, and horrific creations born of forbidden science. As you search for answers, you uncover a grim tale of mad doctors who tampered with life and death itself, using the patients as unwilling subjects for horrific experiments. The deeper you go, the more you realize that the asylum is not just haunted by ghosts, but by something much darker—an ancient, malevolent force that thrives on fear and suffering. The game is a mix of survival horror and action, where you must confront the asylum's horrors, solve its cryptic puzzles, and survive the tormenting horrors that stalk you through every shadowy corridor. As you delve deeper into the asylum's twisted legacy, you begin to question whether you're simply another victim—or if the asylum’s call has always been meant for you.",
            
        }
        
    };
    
        context.AddRange(games);
        context.SaveChanges();

        List<StudioGame> studioGames = new List<StudioGame>

        {
            // Studio 1 Obsidian Realm Contains 10 Games
            new StudioGame { GameID = 1, StudioID = 1 },
            new StudioGame { GameID = 2, StudioID = 1 },
            new StudioGame { GameID = 3, StudioID = 1 },
            new StudioGame { GameID = 4, StudioID = 1 },
            new StudioGame { GameID = 5, StudioID = 1 },
            new StudioGame { GameID = 6, StudioID = 1 },
            new StudioGame { GameID = 7, StudioID = 1 },
            new StudioGame { GameID = 8, StudioID = 1 },
            new StudioGame { GameID = 9, StudioID = 1 },
            new StudioGame { GameID = 10, StudioID = 1 },

            // Studio 2 RuneBlade Entertainment contains 10 games
            new StudioGame { GameID = 11, StudioID = 2 },
            new StudioGame { GameID = 12, StudioID = 2 },
            new StudioGame { GameID = 13, StudioID = 2 },
            new StudioGame { GameID = 14, StudioID = 2 },
            new StudioGame { GameID = 15, StudioID = 2 },
            new StudioGame { GameID = 16, StudioID = 2 },
            new StudioGame { GameID = 17, StudioID = 2 },
            new StudioGame { GameID = 18, StudioID = 2 },
            new StudioGame { GameID = 19, StudioID = 2 },
            new StudioGame { GameID = 20, StudioID = 2 },

            // Studio 3 Nightshade Interactive contains 10 games
            new StudioGame { GameID = 21, StudioID = 3 },
            new StudioGame { GameID = 22, StudioID = 3 },
            new StudioGame { GameID = 23, StudioID = 3 },
            new StudioGame { GameID = 24, StudioID = 3 },
            new StudioGame { GameID = 25, StudioID = 3 },
            new StudioGame { GameID = 26, StudioID = 3 },
            new StudioGame { GameID = 27, StudioID = 3 },
            new StudioGame { GameID = 28, StudioID = 3 },
            new StudioGame { GameID = 29, StudioID = 3 },
            new StudioGame { GameID = 30, StudioID = 3 },

        };

        context.AddRange(studioGames);
        context.SaveChanges();

    }
}