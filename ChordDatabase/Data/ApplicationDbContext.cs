using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ChordDatabase.Models;

namespace ChordDatabase.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ChordDatabase.Models.Chord> Chord { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder); // keep this: the Identity tables need it

            builder.Entity<Chord>().HasData(
                // ---------- Original seed rows (Id 6 changed to Dorian, the most common m7 scale) ----------
                new Chord { Id = 1, Quality = "Major", Extension = "7", Alterations = "#5", Inversion = "Root", Scale = "Lydian #5", Functions = "Tension", Feeling = "Floating, unresolved" },
                new Chord { Id = 2, Quality = "Major", Scale = "Ionian", Functions = "Tonic, subdominant, dominant", Feeling = "Bright, stable" },
                new Chord { Id = 3, Quality = "Minor", Scale = "Aeolian", Functions = "Tonic", Feeling = "Sad, serious" },
                new Chord { Id = 4, Quality = "Major", Extension = "7", Scale = "Ionian", Functions = "Tonic", Feeling = "Warm, resolved" },
                new Chord { Id = 5, Quality = "Major", Extension = "7", Alterations = "#11", Scale = "Lydian", Functions = "Tonic, subdominant, nonfunctional", Feeling = "Dreamy, bright" },
                new Chord { Id = 6, Quality = "Minor", Extension = "7", Scale = "Dorian", Functions = "Subdominant, tonic", Feeling = "Smooth, mellow" },
                new Chord { Id = 7, Quality = "Minor-Major", Extension = "7", Scale = "Melodic Minor", Functions = "Tonic, tension", Feeling = "Mysterious, cinematic" },

                // ---------- Triads, added tones, and sixths ----------
                new Chord { Id = 8, Quality = "Diminished", Scale = "Locrian", Functions = "Dominant, passing", Feeling = "Tense, unstable" },
                new Chord { Id = 9, Quality = "Augmented", Scale = "Whole Tone", Functions = "Tension", Feeling = "Dreamy, unresolved" },
                new Chord { Id = 10, Quality = "Suspended", Alterations = "sus4", Scale = "Mixolydian", Functions = "Dominant, tension", Feeling = "Open, suspended" },
                new Chord { Id = 11, Quality = "Major", Extension = "add9", Scale = "Ionian", Functions = "Tonic", Feeling = "Shimmering, open" },
                new Chord { Id = 12, Quality = "Major", Extension = "6", Scale = "Ionian", Functions = "Tonic", Feeling = "Warm, vintage" },
                new Chord { Id = 13, Quality = "Major", Extension = "6/9", Scale = "Ionian", Functions = "Tonic", Feeling = "Lush, resolved" },
                new Chord { Id = 14, Quality = "Minor", Extension = "6", Scale = "Dorian", Functions = "Tonic, subdominant", Feeling = "Bittersweet, noir" },
                new Chord { Id = 15, Quality = "Minor", Extension = "6/9", Scale = "Dorian", Functions = "Tonic, subdominant", Feeling = "Smoky, sophisticated" },

                // ---------- Major extensions ----------
                new Chord { Id = 16, Quality = "Major", Extension = "9", Scale = "Ionian", Functions = "Tonic, subdominant", Feeling = "Rich, open" },
                new Chord { Id = 17, Quality = "Major", Extension = "13", Scale = "Ionian", Functions = "Tonic", Feeling = "Lush, full" },
                new Chord { Id = 18, Quality = "Major", Extension = "9", Alterations = "#11", Scale = "Lydian", Functions = "Tonic, subdominant, nonfunctional", Feeling = "Dreamy, floating" },
                new Chord { Id = 19, Quality = "Major", Extension = "13", Alterations = "#11", Scale = "Lydian", Functions = "Tonic, subdominant, nonfunctional", Feeling = "Expansive, shimmering" },

                // ---------- Minor extensions ----------
                new Chord { Id = 20, Quality = "Minor", Extension = "9", Scale = "Dorian", Functions = "Subdominant, tonic", Feeling = "Smooth, mellow" },
                new Chord { Id = 21, Quality = "Minor", Extension = "11", Scale = "Dorian", Functions = "Subdominant, tonic", Feeling = "Spacious, modern" },
                new Chord { Id = 22, Quality = "Minor-Major", Extension = "9", Scale = "Melodic Minor", Functions = "Tonic, tension", Feeling = "Mysterious, elegant" },

                // ---------- Half-diminished and diminished sevenths ----------
                new Chord { Id = 23, Quality = "Half-Diminished", Extension = "7", Scale = "Locrian", Functions = "Subdominant", Feeling = "Dark, yearning" },
                new Chord { Id = 24, Quality = "Half-Diminished", Extension = "9", Scale = "Locrian #2", Functions = "Subdominant", Feeling = "Dark, softened" },
                new Chord { Id = 25, Quality = "Diminished", Extension = "7", Scale = "Diminished (Whole-Half)", Functions = "Dominant, passing", Feeling = "Symmetrical, tense" },

                // ---------- Dominant chords ----------
                new Chord { Id = 26, Quality = "Dominant", Extension = "7", Scale = "Mixolydian", Functions = "Dominant", Feeling = "Bluesy, driving" },
                new Chord { Id = 27, Quality = "Dominant", Extension = "9", Scale = "Mixolydian", Functions = "Dominant", Feeling = "Funky, full" },
                new Chord { Id = 28, Quality = "Dominant", Extension = "13", Scale = "Mixolydian", Functions = "Dominant", Feeling = "Lush, bluesy" },
                new Chord { Id = 29, Quality = "Dominant", Extension = "7", Alterations = "sus4", Scale = "Mixolydian", Functions = "Dominant, tension", Feeling = "Open, suspended" },
                new Chord { Id = 30, Quality = "Dominant", Extension = "9", Alterations = "sus4", Scale = "Mixolydian", Functions = "Dominant, tension", Feeling = "Floating, modern" },
                new Chord { Id = 31, Quality = "Dominant", Extension = "13", Alterations = "sus4", Scale = "Mixolydian", Functions = "Dominant, tension", Feeling = "Airy, unresolved" },

                // ---------- Altered dominants ----------
                new Chord { Id = 32, Quality = "Dominant", Extension = "7", Alterations = "b9", Scale = "Diminished (Half-Whole)", Functions = "Dominant, tension", Feeling = "Dark, urgent" },
                new Chord { Id = 33, Quality = "Dominant", Extension = "13", Alterations = "b9", Scale = "Diminished (Half-Whole)", Functions = "Dominant, tension", Feeling = "Dark, colorful" },
                new Chord { Id = 34, Quality = "Dominant", Extension = "7", Alterations = "#9", Scale = "Altered", Functions = "Dominant, tension", Feeling = "Gritty, edgy" },
                new Chord { Id = 35, Quality = "Dominant", Extension = "7", Alterations = "#11", Scale = "Lydian Dominant", Functions = "Dominant, tritone substitution", Feeling = "Bright, quirky" },
                new Chord { Id = 36, Quality = "Dominant", Extension = "9", Alterations = "#11", Scale = "Lydian Dominant", Functions = "Dominant, tritone substitution", Feeling = "Bright, floating" },
                new Chord { Id = 37, Quality = "Dominant", Extension = "13", Alterations = "#11", Scale = "Lydian Dominant", Functions = "Dominant, tritone substitution", Feeling = "Bright, expansive" },
                new Chord { Id = 38, Quality = "Dominant", Extension = "7", Alterations = "#5", Scale = "Whole Tone", Functions = "Dominant, tension", Feeling = "Floating, unsettled" },
                new Chord { Id = 39, Quality = "Dominant", Extension = "9", Alterations = "#5", Scale = "Whole Tone", Functions = "Dominant, tension", Feeling = "Dreamy, unsettled" },
                new Chord { Id = 40, Quality = "Dominant", Extension = "7", Alterations = "b13", Scale = "Mixolydian b6", Functions = "Dominant", Feeling = "Dark, bittersweet" },
                new Chord { Id = 41, Quality = "Dominant", Extension = "9", Alterations = "b13", Scale = "Mixolydian b6", Functions = "Dominant", Feeling = "Dark, rich" },
                new Chord { Id = 42, Quality = "Dominant", Extension = "7", Alterations = "b9, b13", Scale = "Phrygian Dominant", Functions = "Dominant, tension", Feeling = "Spanish, dramatic" },
                new Chord { Id = 43, Quality = "Dominant", Extension = "7", Alterations = "alt", Scale = "Altered", Functions = "Dominant, tension", Feeling = "Maximum tension" }
            );
        }
    }
}
