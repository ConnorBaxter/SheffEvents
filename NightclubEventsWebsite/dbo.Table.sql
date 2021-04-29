CREATE TABLE [dbo].[Events]
(
	[EventID] INT NOT NULL PRIMARY KEY, 
    [EventTitle] VARCHAR(100) NOT NULL, 
    [ClubName] VARCHAR(100) NOT NULL, 
    [DJName] VARCHAR(100) NULL, 
    [EventDate] DATE NOT NULL, 
    [StartTime] TIME NOT NULL, 
    [EndTime] TIME NULL
)

/*
		[Key]
        public int EventID { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string EventTitle { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string ClubName { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string DJName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime EventDate { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }

        [DataType(DataType.Time)]
        public DateTime EndTime { get; set; }
*/