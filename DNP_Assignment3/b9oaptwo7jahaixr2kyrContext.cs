﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DNP_Assignment3
{
    public partial class b9oaptwo7jahaixr2kyrContext : DbContext
    {
        public b9oaptwo7jahaixr2kyrContext()
        {
        }

        public b9oaptwo7jahaixr2kyrContext(DbContextOptions<b9oaptwo7jahaixr2kyrContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Addr> Addrs { get; set; }
        public virtual DbSet<Addrfeat> Addrfeats { get; set; }
        public virtual DbSet<Adult> Adults { get; set; }
        public virtual DbSet<Bg> Bgs { get; set; }
        public virtual DbSet<County> Counties { get; set; }
        public virtual DbSet<CountyLookup> CountyLookups { get; set; }
        public virtual DbSet<CountysubLookup> CountysubLookups { get; set; }
        public virtual DbSet<Cousub> Cousubs { get; set; }
        public virtual DbSet<DirectionLookup> DirectionLookups { get; set; }
        public virtual DbSet<Edge> Edges { get; set; }
        public virtual DbSet<Face> Faces { get; set; }
        public virtual DbSet<Featname> Featnames { get; set; }
        public virtual DbSet<GeocodeSetting> GeocodeSettings { get; set; }
        public virtual DbSet<GeocodeSettingsDefault> GeocodeSettingsDefaults { get; set; }
        public virtual DbSet<LoaderLookuptable> LoaderLookuptables { get; set; }
        public virtual DbSet<LoaderPlatform> LoaderPlatforms { get; set; }
        public virtual DbSet<LoaderVariable> LoaderVariables { get; set; }
        public virtual DbSet<PagcGaz> PagcGazs { get; set; }
        public virtual DbSet<PagcLex> PagcLices { get; set; }
        public virtual DbSet<PagcRule> PagcRules { get; set; }
        public virtual DbSet<PgBuffercache> PgBuffercaches { get; set; }
        public virtual DbSet<PgStatStatement> PgStatStatements { get; set; }
        public virtual DbSet<Place> Places { get; set; }
        public virtual DbSet<PlaceLookup> PlaceLookups { get; set; }
        public virtual DbSet<SecondaryUnitLookup> SecondaryUnitLookups { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<StateLookup> StateLookups { get; set; }
        public virtual DbSet<StreetTypeLookup> StreetTypeLookups { get; set; }
        public virtual DbSet<Tabblock> Tabblocks { get; set; }
        public virtual DbSet<Tract> Tracts { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Zcta5> Zcta5s { get; set; }
        public virtual DbSet<ZipLookup> ZipLookups { get; set; }
        public virtual DbSet<ZipLookupAll> ZipLookupAlls { get; set; }
        public virtual DbSet<ZipLookupBase> ZipLookupBases { get; set; }
        public virtual DbSet<ZipState> ZipStates { get; set; }
        public virtual DbSet<ZipStateLoc> ZipStateLocs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=b9oaptwo7jahaixr2kyr-postgresql.services.clever-cloud.com;Database=b9oaptwo7jahaixr2kyr;Username=ufxdpdo5phqqd3bjrk1u;Password=k9cI75OgnkgGZVZqR18R");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("adminpack")
                .HasPostgresExtension("autoinc")
                .HasPostgresExtension("btree_gin")
                .HasPostgresExtension("btree_gist")
                .HasPostgresExtension("citext")
                .HasPostgresExtension("cube")
                .HasPostgresExtension("dblink")
                .HasPostgresExtension("dict_int")
                .HasPostgresExtension("dict_xsyn")
                .HasPostgresExtension("earthdistance")
                .HasPostgresExtension("file_fdw")
                .HasPostgresExtension("fuzzystrmatch")
                .HasPostgresExtension("hstore")
                .HasPostgresExtension("insert_username")
                .HasPostgresExtension("intagg")
                .HasPostgresExtension("intarray")
                .HasPostgresExtension("isn")
                .HasPostgresExtension("lo")
                .HasPostgresExtension("ltree")
                .HasPostgresExtension("moddatetime")
                .HasPostgresExtension("pageinspect")
                .HasPostgresExtension("pg_buffercache")
                .HasPostgresExtension("pg_freespacemap")
                .HasPostgresExtension("pg_stat_statements")
                .HasPostgresExtension("pg_trgm")
                .HasPostgresExtension("pgcrypto")
                .HasPostgresExtension("pgrowlocks")
                .HasPostgresExtension("pgstattuple")
                .HasPostgresExtension("postgis")
                .HasPostgresExtension("postgis_tiger_geocoder")
                .HasPostgresExtension("refint")
                .HasPostgresExtension("seg")
                .HasPostgresExtension("sslinfo")
                .HasPostgresExtension("tablefunc")
                .HasPostgresExtension("tcn")
                .HasPostgresExtension("timetravel")
                .HasPostgresExtension("unaccent")
                .HasPostgresExtension("uuid-ossp")
                .HasPostgresExtension("xml2");

            modelBuilder.Entity<Addr>(entity =>
            {
                entity.HasKey(e => e.Gid)
                    .HasName("addr_pkey");

                entity.ToTable("addr", "tiger");

                entity.HasIndex(e => new { e.Tlid, e.Statefp }, "idx_tiger_addr_tlid_statefp");

                entity.HasIndex(e => e.Zip, "idx_tiger_addr_zip");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.Arid)
                    .HasMaxLength(22)
                    .HasColumnName("arid");

                entity.Property(e => e.Fromarmid).HasColumnName("fromarmid");

                entity.Property(e => e.Fromhn)
                    .HasMaxLength(12)
                    .HasColumnName("fromhn");

                entity.Property(e => e.Fromtyp)
                    .HasMaxLength(1)
                    .HasColumnName("fromtyp");

                entity.Property(e => e.Mtfcc)
                    .HasMaxLength(5)
                    .HasColumnName("mtfcc");

                entity.Property(e => e.Plus4)
                    .HasMaxLength(4)
                    .HasColumnName("plus4");

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .HasColumnName("side");

                entity.Property(e => e.Statefp)
                    .HasMaxLength(2)
                    .HasColumnName("statefp");

                entity.Property(e => e.Tlid).HasColumnName("tlid");

                entity.Property(e => e.Toarmid).HasColumnName("toarmid");

                entity.Property(e => e.Tohn)
                    .HasMaxLength(12)
                    .HasColumnName("tohn");

                entity.Property(e => e.Totyp)
                    .HasMaxLength(1)
                    .HasColumnName("totyp");

                entity.Property(e => e.Zip)
                    .HasMaxLength(5)
                    .HasColumnName("zip");
            });

            modelBuilder.Entity<Addrfeat>(entity =>
            {
                entity.HasKey(e => e.Gid)
                    .HasName("addrfeat_pkey");

                entity.ToTable("addrfeat", "tiger");

                entity.HasIndex(e => e.Tlid, "idx_addrfeat_tlid");

                entity.HasIndex(e => e.Zipl, "idx_addrfeat_zipl");

                entity.HasIndex(e => e.Zipr, "idx_addrfeat_zipr");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.Aridl)
                    .HasMaxLength(22)
                    .HasColumnName("aridl");

                entity.Property(e => e.Aridr)
                    .HasMaxLength(22)
                    .HasColumnName("aridr");

                entity.Property(e => e.EdgeMtfcc)
                    .HasMaxLength(5)
                    .HasColumnName("edge_mtfcc");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(100)
                    .HasColumnName("fullname");

                entity.Property(e => e.Lfromhn)
                    .HasMaxLength(12)
                    .HasColumnName("lfromhn");

                entity.Property(e => e.Lfromtyp)
                    .HasMaxLength(1)
                    .HasColumnName("lfromtyp");

                entity.Property(e => e.Linearid)
                    .HasMaxLength(22)
                    .HasColumnName("linearid");

                entity.Property(e => e.Ltohn)
                    .HasMaxLength(12)
                    .HasColumnName("ltohn");

                entity.Property(e => e.Ltotyp)
                    .HasMaxLength(1)
                    .HasColumnName("ltotyp");

                entity.Property(e => e.Offsetl)
                    .HasMaxLength(1)
                    .HasColumnName("offsetl");

                entity.Property(e => e.Offsetr)
                    .HasMaxLength(1)
                    .HasColumnName("offsetr");

                entity.Property(e => e.Parityl)
                    .HasMaxLength(1)
                    .HasColumnName("parityl");

                entity.Property(e => e.Parityr)
                    .HasMaxLength(1)
                    .HasColumnName("parityr");

                entity.Property(e => e.Plus4l)
                    .HasMaxLength(4)
                    .HasColumnName("plus4l");

                entity.Property(e => e.Plus4r)
                    .HasMaxLength(4)
                    .HasColumnName("plus4r");

                entity.Property(e => e.Rfromhn)
                    .HasMaxLength(12)
                    .HasColumnName("rfromhn");

                entity.Property(e => e.Rfromtyp)
                    .HasMaxLength(1)
                    .HasColumnName("rfromtyp");

                entity.Property(e => e.Rtohn)
                    .HasMaxLength(12)
                    .HasColumnName("rtohn");

                entity.Property(e => e.Rtotyp)
                    .HasMaxLength(1)
                    .HasColumnName("rtotyp");

                entity.Property(e => e.Statefp)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("statefp");

                entity.Property(e => e.Tlid).HasColumnName("tlid");

                entity.Property(e => e.Zipl)
                    .HasMaxLength(5)
                    .HasColumnName("zipl");

                entity.Property(e => e.Zipr)
                    .HasMaxLength(5)
                    .HasColumnName("zipr");
            });

            modelBuilder.Entity<Adult>(entity =>
            {
                entity.ToTable("adult", "assignment4");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.EyeColor)
                    .HasColumnType("character varying")
                    .HasColumnName("eye_color");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("firstName");

                entity.Property(e => e.HairColor)
                    .HasColumnType("character varying")
                    .HasColumnName("hair_color");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.JobTitle)
                    .HasColumnType("character varying")
                    .HasColumnName("job_title");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("last_name");

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("sex");

                entity.Property(e => e.Weight).HasColumnName("weight");
            });

            modelBuilder.Entity<Bg>(entity =>
            {
                entity.ToTable("bg", "tiger");

                entity.HasComment("block groups");

                entity.Property(e => e.BgId)
                    .HasMaxLength(12)
                    .HasColumnName("bg_id");

                entity.Property(e => e.Aland).HasColumnName("aland");

                entity.Property(e => e.Awater).HasColumnName("awater");

                entity.Property(e => e.Blkgrpce)
                    .HasMaxLength(1)
                    .HasColumnName("blkgrpce");

                entity.Property(e => e.Countyfp)
                    .HasMaxLength(3)
                    .HasColumnName("countyfp");

                entity.Property(e => e.Funcstat)
                    .HasMaxLength(1)
                    .HasColumnName("funcstat");

                entity.Property(e => e.Gid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("gid");

                entity.Property(e => e.Intptlat)
                    .HasMaxLength(11)
                    .HasColumnName("intptlat");

                entity.Property(e => e.Intptlon)
                    .HasMaxLength(12)
                    .HasColumnName("intptlon");

                entity.Property(e => e.Mtfcc)
                    .HasMaxLength(5)
                    .HasColumnName("mtfcc");

                entity.Property(e => e.Namelsad)
                    .HasMaxLength(13)
                    .HasColumnName("namelsad");

                entity.Property(e => e.Statefp)
                    .HasMaxLength(2)
                    .HasColumnName("statefp");

                entity.Property(e => e.Tractce)
                    .HasMaxLength(6)
                    .HasColumnName("tractce");
            });

            modelBuilder.Entity<County>(entity =>
            {
                entity.HasKey(e => e.Cntyidfp)
                    .HasName("pk_tiger_county");

                entity.ToTable("county", "tiger");

                entity.HasIndex(e => e.Countyfp, "idx_tiger_county");

                entity.HasIndex(e => e.Gid, "uidx_county_gid")
                    .IsUnique();

                entity.Property(e => e.Cntyidfp)
                    .HasMaxLength(5)
                    .HasColumnName("cntyidfp");

                entity.Property(e => e.Aland).HasColumnName("aland");

                entity.Property(e => e.Awater).HasColumnName("awater");

                entity.Property(e => e.Cbsafp)
                    .HasMaxLength(5)
                    .HasColumnName("cbsafp");

                entity.Property(e => e.Classfp)
                    .HasMaxLength(2)
                    .HasColumnName("classfp");

                entity.Property(e => e.Countyfp)
                    .HasMaxLength(3)
                    .HasColumnName("countyfp");

                entity.Property(e => e.Countyns)
                    .HasMaxLength(8)
                    .HasColumnName("countyns");

                entity.Property(e => e.Csafp)
                    .HasMaxLength(3)
                    .HasColumnName("csafp");

                entity.Property(e => e.Funcstat)
                    .HasMaxLength(1)
                    .HasColumnName("funcstat");

                entity.Property(e => e.Gid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("gid");

                entity.Property(e => e.Intptlat)
                    .HasMaxLength(11)
                    .HasColumnName("intptlat");

                entity.Property(e => e.Intptlon)
                    .HasMaxLength(12)
                    .HasColumnName("intptlon");

                entity.Property(e => e.Lsad)
                    .HasMaxLength(2)
                    .HasColumnName("lsad");

                entity.Property(e => e.Metdivfp)
                    .HasMaxLength(5)
                    .HasColumnName("metdivfp");

                entity.Property(e => e.Mtfcc)
                    .HasMaxLength(5)
                    .HasColumnName("mtfcc");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Namelsad)
                    .HasMaxLength(100)
                    .HasColumnName("namelsad");

                entity.Property(e => e.Statefp)
                    .HasMaxLength(2)
                    .HasColumnName("statefp");
            });

            modelBuilder.Entity<CountyLookup>(entity =>
            {
                entity.HasKey(e => new { e.StCode, e.CoCode })
                    .HasName("county_lookup_pkey");

                entity.ToTable("county_lookup", "tiger");

                entity.HasIndex(e => e.State, "county_lookup_state_idx");

                entity.Property(e => e.StCode).HasColumnName("st_code");

                entity.Property(e => e.CoCode).HasColumnName("co_code");

                entity.Property(e => e.Name)
                    .HasMaxLength(90)
                    .HasColumnName("name");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .HasColumnName("state");
            });

            modelBuilder.Entity<CountysubLookup>(entity =>
            {
                entity.HasKey(e => new { e.StCode, e.CoCode, e.CsCode })
                    .HasName("countysub_lookup_pkey");

                entity.ToTable("countysub_lookup", "tiger");

                entity.HasIndex(e => e.State, "countysub_lookup_state_idx");

                entity.Property(e => e.StCode).HasColumnName("st_code");

                entity.Property(e => e.CoCode).HasColumnName("co_code");

                entity.Property(e => e.CsCode).HasColumnName("cs_code");

                entity.Property(e => e.County)
                    .HasMaxLength(90)
                    .HasColumnName("county");

                entity.Property(e => e.Name)
                    .HasMaxLength(90)
                    .HasColumnName("name");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .HasColumnName("state");
            });

            modelBuilder.Entity<Cousub>(entity =>
            {
                entity.HasKey(e => e.Cosbidfp)
                    .HasName("cousub_pkey");

                entity.ToTable("cousub", "tiger");

                entity.HasIndex(e => e.Gid, "uidx_cousub_gid")
                    .IsUnique();

                entity.Property(e => e.Cosbidfp)
                    .HasMaxLength(10)
                    .HasColumnName("cosbidfp");

                entity.Property(e => e.Aland)
                    .HasPrecision(14)
                    .HasColumnName("aland");

                entity.Property(e => e.Awater)
                    .HasPrecision(14)
                    .HasColumnName("awater");

                entity.Property(e => e.Classfp)
                    .HasMaxLength(2)
                    .HasColumnName("classfp");

                entity.Property(e => e.Cnectafp)
                    .HasMaxLength(3)
                    .HasColumnName("cnectafp");

                entity.Property(e => e.Countyfp)
                    .HasMaxLength(3)
                    .HasColumnName("countyfp");

                entity.Property(e => e.Cousubfp)
                    .HasMaxLength(5)
                    .HasColumnName("cousubfp");

                entity.Property(e => e.Cousubns)
                    .HasMaxLength(8)
                    .HasColumnName("cousubns");

                entity.Property(e => e.Funcstat)
                    .HasMaxLength(1)
                    .HasColumnName("funcstat");

                entity.Property(e => e.Gid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("gid");

                entity.Property(e => e.Intptlat)
                    .HasMaxLength(11)
                    .HasColumnName("intptlat");

                entity.Property(e => e.Intptlon)
                    .HasMaxLength(12)
                    .HasColumnName("intptlon");

                entity.Property(e => e.Lsad)
                    .HasMaxLength(2)
                    .HasColumnName("lsad");

                entity.Property(e => e.Mtfcc)
                    .HasMaxLength(5)
                    .HasColumnName("mtfcc");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Namelsad)
                    .HasMaxLength(100)
                    .HasColumnName("namelsad");

                entity.Property(e => e.Nctadvfp)
                    .HasMaxLength(5)
                    .HasColumnName("nctadvfp");

                entity.Property(e => e.Nectafp)
                    .HasMaxLength(5)
                    .HasColumnName("nectafp");

                entity.Property(e => e.Statefp)
                    .HasMaxLength(2)
                    .HasColumnName("statefp");
            });

            modelBuilder.Entity<DirectionLookup>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("direction_lookup_pkey");

                entity.ToTable("direction_lookup", "tiger");

                entity.HasIndex(e => e.Abbrev, "direction_lookup_abbrev_idx");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("name");

                entity.Property(e => e.Abbrev)
                    .HasMaxLength(3)
                    .HasColumnName("abbrev");
            });

            modelBuilder.Entity<Edge>(entity =>
            {
                entity.HasKey(e => e.Gid)
                    .HasName("edges_pkey");

                entity.ToTable("edges", "tiger");

                entity.HasIndex(e => e.Tlid, "idx_edges_tlid");

                entity.HasIndex(e => e.Countyfp, "idx_tiger_edges_countyfp");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.Artpath)
                    .HasMaxLength(1)
                    .HasColumnName("artpath");

                entity.Property(e => e.Countyfp)
                    .HasMaxLength(3)
                    .HasColumnName("countyfp");

                entity.Property(e => e.Deckedroad)
                    .HasMaxLength(1)
                    .HasColumnName("deckedroad");

                entity.Property(e => e.Divroad)
                    .HasMaxLength(1)
                    .HasColumnName("divroad");

                entity.Property(e => e.Exttyp)
                    .HasMaxLength(1)
                    .HasColumnName("exttyp");

                entity.Property(e => e.Featcat)
                    .HasMaxLength(1)
                    .HasColumnName("featcat");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(100)
                    .HasColumnName("fullname");

                entity.Property(e => e.Gcseflg)
                    .HasMaxLength(1)
                    .HasColumnName("gcseflg");

                entity.Property(e => e.Hydroflg)
                    .HasMaxLength(1)
                    .HasColumnName("hydroflg");

                entity.Property(e => e.Lfromadd)
                    .HasMaxLength(12)
                    .HasColumnName("lfromadd");

                entity.Property(e => e.Ltoadd)
                    .HasMaxLength(12)
                    .HasColumnName("ltoadd");

                entity.Property(e => e.Mtfcc)
                    .HasMaxLength(5)
                    .HasColumnName("mtfcc");

                entity.Property(e => e.Offsetl)
                    .HasMaxLength(1)
                    .HasColumnName("offsetl");

                entity.Property(e => e.Offsetr)
                    .HasMaxLength(1)
                    .HasColumnName("offsetr");

                entity.Property(e => e.Olfflg)
                    .HasMaxLength(1)
                    .HasColumnName("olfflg");

                entity.Property(e => e.Passflg)
                    .HasMaxLength(1)
                    .HasColumnName("passflg");

                entity.Property(e => e.Persist)
                    .HasMaxLength(1)
                    .HasColumnName("persist");

                entity.Property(e => e.Railflg)
                    .HasMaxLength(1)
                    .HasColumnName("railflg");

                entity.Property(e => e.Rfromadd)
                    .HasMaxLength(12)
                    .HasColumnName("rfromadd");

                entity.Property(e => e.Roadflg)
                    .HasMaxLength(1)
                    .HasColumnName("roadflg");

                entity.Property(e => e.Rtoadd)
                    .HasMaxLength(12)
                    .HasColumnName("rtoadd");

                entity.Property(e => e.Smid)
                    .HasMaxLength(22)
                    .HasColumnName("smid");

                entity.Property(e => e.Statefp)
                    .HasMaxLength(2)
                    .HasColumnName("statefp");

                entity.Property(e => e.Tfidl)
                    .HasPrecision(10)
                    .HasColumnName("tfidl");

                entity.Property(e => e.Tfidr)
                    .HasPrecision(10)
                    .HasColumnName("tfidr");

                entity.Property(e => e.Tlid).HasColumnName("tlid");

                entity.Property(e => e.Tnidf)
                    .HasPrecision(10)
                    .HasColumnName("tnidf");

                entity.Property(e => e.Tnidt)
                    .HasPrecision(10)
                    .HasColumnName("tnidt");

                entity.Property(e => e.Ttyp)
                    .HasMaxLength(1)
                    .HasColumnName("ttyp");

                entity.Property(e => e.Zipl)
                    .HasMaxLength(5)
                    .HasColumnName("zipl");

                entity.Property(e => e.Zipr)
                    .HasMaxLength(5)
                    .HasColumnName("zipr");
            });

            modelBuilder.Entity<Face>(entity =>
            {
                entity.HasKey(e => e.Gid)
                    .HasName("faces_pkey");

                entity.ToTable("faces", "tiger");

                entity.HasIndex(e => e.Countyfp, "idx_tiger_faces_countyfp");

                entity.HasIndex(e => e.Tfid, "idx_tiger_faces_tfid");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.Aiannhce)
                    .HasMaxLength(4)
                    .HasColumnName("aiannhce");

                entity.Property(e => e.Aiannhce00)
                    .HasMaxLength(4)
                    .HasColumnName("aiannhce00");

                entity.Property(e => e.Aiannhfp)
                    .HasMaxLength(5)
                    .HasColumnName("aiannhfp");

                entity.Property(e => e.Aiannhfp00)
                    .HasMaxLength(5)
                    .HasColumnName("aiannhfp00");

                entity.Property(e => e.Anrcfp)
                    .HasMaxLength(5)
                    .HasColumnName("anrcfp");

                entity.Property(e => e.Anrcfp00)
                    .HasMaxLength(5)
                    .HasColumnName("anrcfp00");

                entity.Property(e => e.Atotal).HasColumnName("atotal");

                entity.Property(e => e.Blkgrpce)
                    .HasMaxLength(1)
                    .HasColumnName("blkgrpce");

                entity.Property(e => e.Blkgrpce00)
                    .HasMaxLength(1)
                    .HasColumnName("blkgrpce00");

                entity.Property(e => e.Blockce)
                    .HasMaxLength(4)
                    .HasColumnName("blockce");

                entity.Property(e => e.Blockce00)
                    .HasMaxLength(4)
                    .HasColumnName("blockce00");

                entity.Property(e => e.Cbsafp)
                    .HasMaxLength(5)
                    .HasColumnName("cbsafp");

                entity.Property(e => e.Cd108fp)
                    .HasMaxLength(2)
                    .HasColumnName("cd108fp");

                entity.Property(e => e.Cd111fp)
                    .HasMaxLength(2)
                    .HasColumnName("cd111fp");

                entity.Property(e => e.Cnectafp)
                    .HasMaxLength(3)
                    .HasColumnName("cnectafp");

                entity.Property(e => e.Comptyp)
                    .HasMaxLength(1)
                    .HasColumnName("comptyp");

                entity.Property(e => e.Comptyp00)
                    .HasMaxLength(1)
                    .HasColumnName("comptyp00");

                entity.Property(e => e.Conctyfp)
                    .HasMaxLength(5)
                    .HasColumnName("conctyfp");

                entity.Property(e => e.Conctyfp00)
                    .HasMaxLength(5)
                    .HasColumnName("conctyfp00");

                entity.Property(e => e.Countyfp)
                    .HasMaxLength(3)
                    .HasColumnName("countyfp");

                entity.Property(e => e.Countyfp00)
                    .HasMaxLength(3)
                    .HasColumnName("countyfp00");

                entity.Property(e => e.Cousubfp)
                    .HasMaxLength(5)
                    .HasColumnName("cousubfp");

                entity.Property(e => e.Cousubfp00)
                    .HasMaxLength(5)
                    .HasColumnName("cousubfp00");

                entity.Property(e => e.Csafp)
                    .HasMaxLength(3)
                    .HasColumnName("csafp");

                entity.Property(e => e.Elsdlea)
                    .HasMaxLength(5)
                    .HasColumnName("elsdlea");

                entity.Property(e => e.Elsdlea00)
                    .HasMaxLength(5)
                    .HasColumnName("elsdlea00");

                entity.Property(e => e.Intptlat)
                    .HasMaxLength(11)
                    .HasColumnName("intptlat");

                entity.Property(e => e.Intptlon)
                    .HasMaxLength(12)
                    .HasColumnName("intptlon");

                entity.Property(e => e.Lwflag)
                    .HasMaxLength(1)
                    .HasColumnName("lwflag");

                entity.Property(e => e.Metdivfp)
                    .HasMaxLength(5)
                    .HasColumnName("metdivfp");

                entity.Property(e => e.Nctadvfp)
                    .HasMaxLength(5)
                    .HasColumnName("nctadvfp");

                entity.Property(e => e.Nectafp)
                    .HasMaxLength(5)
                    .HasColumnName("nectafp");

                entity.Property(e => e.Offset)
                    .HasMaxLength(1)
                    .HasColumnName("offset");

                entity.Property(e => e.Placefp)
                    .HasMaxLength(5)
                    .HasColumnName("placefp");

                entity.Property(e => e.Placefp00)
                    .HasMaxLength(5)
                    .HasColumnName("placefp00");

                entity.Property(e => e.Puma5ce)
                    .HasMaxLength(5)
                    .HasColumnName("puma5ce");

                entity.Property(e => e.Puma5ce00)
                    .HasMaxLength(5)
                    .HasColumnName("puma5ce00");

                entity.Property(e => e.Scsdlea)
                    .HasMaxLength(5)
                    .HasColumnName("scsdlea");

                entity.Property(e => e.Scsdlea00)
                    .HasMaxLength(5)
                    .HasColumnName("scsdlea00");

                entity.Property(e => e.Sldlst)
                    .HasMaxLength(3)
                    .HasColumnName("sldlst");

                entity.Property(e => e.Sldlst00)
                    .HasMaxLength(3)
                    .HasColumnName("sldlst00");

                entity.Property(e => e.Sldust)
                    .HasMaxLength(3)
                    .HasColumnName("sldust");

                entity.Property(e => e.Sldust00)
                    .HasMaxLength(3)
                    .HasColumnName("sldust00");

                entity.Property(e => e.Statefp)
                    .HasMaxLength(2)
                    .HasColumnName("statefp");

                entity.Property(e => e.Statefp00)
                    .HasMaxLength(2)
                    .HasColumnName("statefp00");

                entity.Property(e => e.Submcdfp)
                    .HasMaxLength(5)
                    .HasColumnName("submcdfp");

                entity.Property(e => e.Submcdfp00)
                    .HasMaxLength(5)
                    .HasColumnName("submcdfp00");

                entity.Property(e => e.Tazce)
                    .HasMaxLength(6)
                    .HasColumnName("tazce");

                entity.Property(e => e.Tazce00)
                    .HasMaxLength(6)
                    .HasColumnName("tazce00");

                entity.Property(e => e.Tblkgpce)
                    .HasMaxLength(1)
                    .HasColumnName("tblkgpce");

                entity.Property(e => e.Tfid)
                    .HasPrecision(10)
                    .HasColumnName("tfid");

                entity.Property(e => e.Tractce)
                    .HasMaxLength(6)
                    .HasColumnName("tractce");

                entity.Property(e => e.Tractce00)
                    .HasMaxLength(6)
                    .HasColumnName("tractce00");

                entity.Property(e => e.Trsubce)
                    .HasMaxLength(3)
                    .HasColumnName("trsubce");

                entity.Property(e => e.Trsubce00)
                    .HasMaxLength(3)
                    .HasColumnName("trsubce00");

                entity.Property(e => e.Trsubfp)
                    .HasMaxLength(5)
                    .HasColumnName("trsubfp");

                entity.Property(e => e.Trsubfp00)
                    .HasMaxLength(5)
                    .HasColumnName("trsubfp00");

                entity.Property(e => e.Ttractce)
                    .HasMaxLength(6)
                    .HasColumnName("ttractce");

                entity.Property(e => e.Uace)
                    .HasMaxLength(5)
                    .HasColumnName("uace");

                entity.Property(e => e.Uace00)
                    .HasMaxLength(5)
                    .HasColumnName("uace00");

                entity.Property(e => e.Ugace)
                    .HasMaxLength(5)
                    .HasColumnName("ugace");

                entity.Property(e => e.Ugace00)
                    .HasMaxLength(5)
                    .HasColumnName("ugace00");

                entity.Property(e => e.Unsdlea)
                    .HasMaxLength(5)
                    .HasColumnName("unsdlea");

                entity.Property(e => e.Unsdlea00)
                    .HasMaxLength(5)
                    .HasColumnName("unsdlea00");

                entity.Property(e => e.Vtdst)
                    .HasMaxLength(6)
                    .HasColumnName("vtdst");

                entity.Property(e => e.Vtdst00)
                    .HasMaxLength(6)
                    .HasColumnName("vtdst00");

                entity.Property(e => e.Zcta5ce)
                    .HasMaxLength(5)
                    .HasColumnName("zcta5ce");

                entity.Property(e => e.Zcta5ce00)
                    .HasMaxLength(5)
                    .HasColumnName("zcta5ce00");
            });

            modelBuilder.Entity<Featname>(entity =>
            {
                entity.HasKey(e => e.Gid)
                    .HasName("featnames_pkey");

                entity.ToTable("featnames", "tiger");

                entity.HasIndex(e => new { e.Tlid, e.Statefp }, "idx_tiger_featnames_tlid_statefp");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(100)
                    .HasColumnName("fullname");

                entity.Property(e => e.Linearid)
                    .HasMaxLength(22)
                    .HasColumnName("linearid");

                entity.Property(e => e.Mtfcc)
                    .HasMaxLength(5)
                    .HasColumnName("mtfcc");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Paflag)
                    .HasMaxLength(1)
                    .HasColumnName("paflag");

                entity.Property(e => e.Predir)
                    .HasMaxLength(2)
                    .HasColumnName("predir");

                entity.Property(e => e.Predirabrv)
                    .HasMaxLength(15)
                    .HasColumnName("predirabrv");

                entity.Property(e => e.Prequal)
                    .HasMaxLength(2)
                    .HasColumnName("prequal");

                entity.Property(e => e.Prequalabr)
                    .HasMaxLength(15)
                    .HasColumnName("prequalabr");

                entity.Property(e => e.Pretyp)
                    .HasMaxLength(3)
                    .HasColumnName("pretyp");

                entity.Property(e => e.Pretypabrv)
                    .HasMaxLength(50)
                    .HasColumnName("pretypabrv");

                entity.Property(e => e.Statefp)
                    .HasMaxLength(2)
                    .HasColumnName("statefp");

                entity.Property(e => e.Sufdir)
                    .HasMaxLength(2)
                    .HasColumnName("sufdir");

                entity.Property(e => e.Sufdirabrv)
                    .HasMaxLength(15)
                    .HasColumnName("sufdirabrv");

                entity.Property(e => e.Sufqual)
                    .HasMaxLength(2)
                    .HasColumnName("sufqual");

                entity.Property(e => e.Sufqualabr)
                    .HasMaxLength(15)
                    .HasColumnName("sufqualabr");

                entity.Property(e => e.Suftyp)
                    .HasMaxLength(3)
                    .HasColumnName("suftyp");

                entity.Property(e => e.Suftypabrv)
                    .HasMaxLength(50)
                    .HasColumnName("suftypabrv");

                entity.Property(e => e.Tlid).HasColumnName("tlid");
            });

            modelBuilder.Entity<GeocodeSetting>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("geocode_settings_pkey");

                entity.ToTable("geocode_settings", "tiger");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.Setting).HasColumnName("setting");

                entity.Property(e => e.ShortDesc).HasColumnName("short_desc");

                entity.Property(e => e.Unit).HasColumnName("unit");
            });

            modelBuilder.Entity<GeocodeSettingsDefault>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("geocode_settings_default_pkey");

                entity.ToTable("geocode_settings_default", "tiger");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.Setting).HasColumnName("setting");

                entity.Property(e => e.ShortDesc).HasColumnName("short_desc");

                entity.Property(e => e.Unit).HasColumnName("unit");
            });

            modelBuilder.Entity<LoaderLookuptable>(entity =>
            {
                entity.HasKey(e => e.LookupName)
                    .HasName("loader_lookuptables_pkey");

                entity.ToTable("loader_lookuptables", "tiger");

                entity.Property(e => e.LookupName)
                    .HasColumnName("lookup_name")
                    .HasComment("This is the table name to inherit from and suffix of resulting output table -- how the table will be named --  edges here would mean -- ma_edges , pa_edges etc. except in the case of national tables. national level tables have no prefix");

                entity.Property(e => e.ColumnsExclude)
                    .HasColumnName("columns_exclude")
                    .HasComment("List of columns to exclude as an array. This is excluded from both input table and output table and rest of columns remaining are assumed to be in same order in both tables. gid, geoid,cpi,suffix1ce are excluded if no columns are specified.");

                entity.Property(e => e.InsertMode)
                    .HasMaxLength(1)
                    .HasColumnName("insert_mode")
                    .HasDefaultValueSql("'c'::bpchar");

                entity.Property(e => e.LevelCounty).HasColumnName("level_county");

                entity.Property(e => e.LevelNation)
                    .HasColumnName("level_nation")
                    .HasComment("These are tables that contain all data for the whole US so there is just a single file");

                entity.Property(e => e.LevelState).HasColumnName("level_state");

                entity.Property(e => e.Load)
                    .IsRequired()
                    .HasColumnName("load")
                    .HasDefaultValueSql("true")
                    .HasComment("Whether or not to load the table.  For states and zcta5 (you may just want to download states10, zcta510 nationwide file manually) load your own into a single table that inherits from tiger.states, tiger.zcta5.  You'll get improved performance for some geocoding cases.");

                entity.Property(e => e.PostLoadProcess).HasColumnName("post_load_process");

                entity.Property(e => e.PreLoadProcess).HasColumnName("pre_load_process");

                entity.Property(e => e.ProcessOrder)
                    .HasColumnName("process_order")
                    .HasDefaultValueSql("1000");

                entity.Property(e => e.SingleGeomMode)
                    .HasColumnName("single_geom_mode")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.SingleMode)
                    .IsRequired()
                    .HasColumnName("single_mode")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TableName)
                    .HasColumnName("table_name")
                    .HasComment("suffix of the tables to load e.g.  edges would load all tables like *edges.dbf(shp)  -- so tl_2010_42129_edges.dbf .  ");

                entity.Property(e => e.WebsiteRootOverride)
                    .HasColumnName("website_root_override")
                    .HasComment("Path to use for wget instead of that specified in year table.  Needed currently for zcta where they release that only for 2000 and 2010");
            });

            modelBuilder.Entity<LoaderPlatform>(entity =>
            {
                entity.HasKey(e => e.Os)
                    .HasName("loader_platform_pkey");

                entity.ToTable("loader_platform", "tiger");

                entity.Property(e => e.Os)
                    .HasMaxLength(50)
                    .HasColumnName("os");

                entity.Property(e => e.CountyProcessCommand).HasColumnName("county_process_command");

                entity.Property(e => e.DeclareSect).HasColumnName("declare_sect");

                entity.Property(e => e.EnvironSetCommand).HasColumnName("environ_set_command");

                entity.Property(e => e.Loader).HasColumnName("loader");

                entity.Property(e => e.PathSep).HasColumnName("path_sep");

                entity.Property(e => e.Pgbin).HasColumnName("pgbin");

                entity.Property(e => e.Psql).HasColumnName("psql");

                entity.Property(e => e.UnzipCommand).HasColumnName("unzip_command");

                entity.Property(e => e.Wget).HasColumnName("wget");
            });

            modelBuilder.Entity<LoaderVariable>(entity =>
            {
                entity.HasKey(e => e.TigerYear)
                    .HasName("loader_variables_pkey");

                entity.ToTable("loader_variables", "tiger");

                entity.Property(e => e.TigerYear)
                    .HasMaxLength(4)
                    .HasColumnName("tiger_year");

                entity.Property(e => e.DataSchema).HasColumnName("data_schema");

                entity.Property(e => e.StagingFold).HasColumnName("staging_fold");

                entity.Property(e => e.StagingSchema).HasColumnName("staging_schema");

                entity.Property(e => e.WebsiteRoot).HasColumnName("website_root");
            });

            modelBuilder.Entity<PagcGaz>(entity =>
            {
                entity.ToTable("pagc_gaz", "tiger");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsCustom)
                    .IsRequired()
                    .HasColumnName("is_custom")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.Stdword).HasColumnName("stdword");

                entity.Property(e => e.Token).HasColumnName("token");

                entity.Property(e => e.Word).HasColumnName("word");
            });

            modelBuilder.Entity<PagcLex>(entity =>
            {
                entity.ToTable("pagc_lex", "tiger");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsCustom)
                    .IsRequired()
                    .HasColumnName("is_custom")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.Stdword).HasColumnName("stdword");

                entity.Property(e => e.Token).HasColumnName("token");

                entity.Property(e => e.Word).HasColumnName("word");
            });

            modelBuilder.Entity<PagcRule>(entity =>
            {
                entity.ToTable("pagc_rules", "tiger");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsCustom)
                    .HasColumnName("is_custom")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Rule).HasColumnName("rule");
            });

            modelBuilder.Entity<PgBuffercache>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pg_buffercache");

                entity.Property(e => e.Bufferid).HasColumnName("bufferid");

                entity.Property(e => e.Isdirty).HasColumnName("isdirty");

                entity.Property(e => e.PinningBackends).HasColumnName("pinning_backends");

                entity.Property(e => e.Relblocknumber).HasColumnName("relblocknumber");

                entity.Property(e => e.Reldatabase)
                    .HasColumnType("oid")
                    .HasColumnName("reldatabase");

                entity.Property(e => e.Relfilenode)
                    .HasColumnType("oid")
                    .HasColumnName("relfilenode");

                entity.Property(e => e.Relforknumber).HasColumnName("relforknumber");

                entity.Property(e => e.Reltablespace)
                    .HasColumnType("oid")
                    .HasColumnName("reltablespace");

                entity.Property(e => e.Usagecount).HasColumnName("usagecount");
            });

            modelBuilder.Entity<PgStatStatement>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pg_stat_statements");

                entity.Property(e => e.BlkReadTime).HasColumnName("blk_read_time");

                entity.Property(e => e.BlkWriteTime).HasColumnName("blk_write_time");

                entity.Property(e => e.Calls).HasColumnName("calls");

                entity.Property(e => e.Dbid)
                    .HasColumnType("oid")
                    .HasColumnName("dbid");

                entity.Property(e => e.LocalBlksDirtied).HasColumnName("local_blks_dirtied");

                entity.Property(e => e.LocalBlksHit).HasColumnName("local_blks_hit");

                entity.Property(e => e.LocalBlksRead).HasColumnName("local_blks_read");

                entity.Property(e => e.LocalBlksWritten).HasColumnName("local_blks_written");

                entity.Property(e => e.MaxTime).HasColumnName("max_time");

                entity.Property(e => e.MeanTime).HasColumnName("mean_time");

                entity.Property(e => e.MinTime).HasColumnName("min_time");

                entity.Property(e => e.Query).HasColumnName("query");

                entity.Property(e => e.Queryid).HasColumnName("queryid");

                entity.Property(e => e.Rows).HasColumnName("rows");

                entity.Property(e => e.SharedBlksDirtied).HasColumnName("shared_blks_dirtied");

                entity.Property(e => e.SharedBlksHit).HasColumnName("shared_blks_hit");

                entity.Property(e => e.SharedBlksRead).HasColumnName("shared_blks_read");

                entity.Property(e => e.SharedBlksWritten).HasColumnName("shared_blks_written");

                entity.Property(e => e.StddevTime).HasColumnName("stddev_time");

                entity.Property(e => e.TempBlksRead).HasColumnName("temp_blks_read");

                entity.Property(e => e.TempBlksWritten).HasColumnName("temp_blks_written");

                entity.Property(e => e.TotalTime).HasColumnName("total_time");

                entity.Property(e => e.Userid)
                    .HasColumnType("oid")
                    .HasColumnName("userid");
            });

            modelBuilder.Entity<Place>(entity =>
            {
                entity.HasKey(e => e.Plcidfp)
                    .HasName("place_pkey");

                entity.ToTable("place", "tiger");

                entity.HasIndex(e => e.Gid, "uidx_tiger_place_gid")
                    .IsUnique();

                entity.Property(e => e.Plcidfp)
                    .HasMaxLength(7)
                    .HasColumnName("plcidfp");

                entity.Property(e => e.Aland).HasColumnName("aland");

                entity.Property(e => e.Awater).HasColumnName("awater");

                entity.Property(e => e.Classfp)
                    .HasMaxLength(2)
                    .HasColumnName("classfp");

                entity.Property(e => e.Cpi)
                    .HasMaxLength(1)
                    .HasColumnName("cpi");

                entity.Property(e => e.Funcstat)
                    .HasMaxLength(1)
                    .HasColumnName("funcstat");

                entity.Property(e => e.Gid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("gid");

                entity.Property(e => e.Intptlat)
                    .HasMaxLength(11)
                    .HasColumnName("intptlat");

                entity.Property(e => e.Intptlon)
                    .HasMaxLength(12)
                    .HasColumnName("intptlon");

                entity.Property(e => e.Lsad)
                    .HasMaxLength(2)
                    .HasColumnName("lsad");

                entity.Property(e => e.Mtfcc)
                    .HasMaxLength(5)
                    .HasColumnName("mtfcc");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Namelsad)
                    .HasMaxLength(100)
                    .HasColumnName("namelsad");

                entity.Property(e => e.Pcicbsa)
                    .HasMaxLength(1)
                    .HasColumnName("pcicbsa");

                entity.Property(e => e.Pcinecta)
                    .HasMaxLength(1)
                    .HasColumnName("pcinecta");

                entity.Property(e => e.Placefp)
                    .HasMaxLength(5)
                    .HasColumnName("placefp");

                entity.Property(e => e.Placens)
                    .HasMaxLength(8)
                    .HasColumnName("placens");

                entity.Property(e => e.Statefp)
                    .HasMaxLength(2)
                    .HasColumnName("statefp");
            });

            modelBuilder.Entity<PlaceLookup>(entity =>
            {
                entity.HasKey(e => new { e.StCode, e.PlCode })
                    .HasName("place_lookup_pkey");

                entity.ToTable("place_lookup", "tiger");

                entity.HasIndex(e => e.State, "place_lookup_state_idx");

                entity.Property(e => e.StCode).HasColumnName("st_code");

                entity.Property(e => e.PlCode).HasColumnName("pl_code");

                entity.Property(e => e.Name)
                    .HasMaxLength(90)
                    .HasColumnName("name");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .HasColumnName("state");
            });

            modelBuilder.Entity<SecondaryUnitLookup>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("secondary_unit_lookup_pkey");

                entity.ToTable("secondary_unit_lookup", "tiger");

                entity.HasIndex(e => e.Abbrev, "secondary_unit_lookup_abbrev_idx");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("name");

                entity.Property(e => e.Abbrev)
                    .HasMaxLength(5)
                    .HasColumnName("abbrev");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasKey(e => e.Statefp)
                    .HasName("pk_tiger_state");

                entity.ToTable("state", "tiger");

                entity.HasIndex(e => e.Gid, "uidx_tiger_state_gid")
                    .IsUnique();

                entity.HasIndex(e => e.Stusps, "uidx_tiger_state_stusps")
                    .IsUnique();

                entity.Property(e => e.Statefp)
                    .HasMaxLength(2)
                    .HasColumnName("statefp");

                entity.Property(e => e.Aland).HasColumnName("aland");

                entity.Property(e => e.Awater).HasColumnName("awater");

                entity.Property(e => e.Division)
                    .HasMaxLength(2)
                    .HasColumnName("division");

                entity.Property(e => e.Funcstat)
                    .HasMaxLength(1)
                    .HasColumnName("funcstat");

                entity.Property(e => e.Gid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("gid");

                entity.Property(e => e.Intptlat)
                    .HasMaxLength(11)
                    .HasColumnName("intptlat");

                entity.Property(e => e.Intptlon)
                    .HasMaxLength(12)
                    .HasColumnName("intptlon");

                entity.Property(e => e.Lsad)
                    .HasMaxLength(2)
                    .HasColumnName("lsad");

                entity.Property(e => e.Mtfcc)
                    .HasMaxLength(5)
                    .HasColumnName("mtfcc");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Region)
                    .HasMaxLength(2)
                    .HasColumnName("region");

                entity.Property(e => e.Statens)
                    .HasMaxLength(8)
                    .HasColumnName("statens");

                entity.Property(e => e.Stusps)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("stusps");
            });

            modelBuilder.Entity<StateLookup>(entity =>
            {
                entity.HasKey(e => e.StCode)
                    .HasName("state_lookup_pkey");

                entity.ToTable("state_lookup", "tiger");

                entity.HasIndex(e => e.Abbrev, "state_lookup_abbrev_key")
                    .IsUnique();

                entity.HasIndex(e => e.Name, "state_lookup_name_key")
                    .IsUnique();

                entity.HasIndex(e => e.Statefp, "state_lookup_statefp_key")
                    .IsUnique();

                entity.Property(e => e.StCode)
                    .ValueGeneratedNever()
                    .HasColumnName("st_code");

                entity.Property(e => e.Abbrev)
                    .HasMaxLength(3)
                    .HasColumnName("abbrev");

                entity.Property(e => e.Name)
                    .HasMaxLength(40)
                    .HasColumnName("name");

                entity.Property(e => e.Statefp)
                    .HasMaxLength(2)
                    .HasColumnName("statefp")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<StreetTypeLookup>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("street_type_lookup_pkey");

                entity.ToTable("street_type_lookup", "tiger");

                entity.HasIndex(e => e.Abbrev, "street_type_lookup_abbrev_idx");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Abbrev)
                    .HasMaxLength(50)
                    .HasColumnName("abbrev");

                entity.Property(e => e.IsHw).HasColumnName("is_hw");
            });

            modelBuilder.Entity<Tabblock>(entity =>
            {
                entity.ToTable("tabblock", "tiger");

                entity.Property(e => e.TabblockId)
                    .HasMaxLength(16)
                    .HasColumnName("tabblock_id");

                entity.Property(e => e.Aland).HasColumnName("aland");

                entity.Property(e => e.Awater).HasColumnName("awater");

                entity.Property(e => e.Blockce)
                    .HasMaxLength(4)
                    .HasColumnName("blockce");

                entity.Property(e => e.Countyfp)
                    .HasMaxLength(3)
                    .HasColumnName("countyfp");

                entity.Property(e => e.Funcstat)
                    .HasMaxLength(1)
                    .HasColumnName("funcstat");

                entity.Property(e => e.Gid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("gid");

                entity.Property(e => e.Intptlat)
                    .HasMaxLength(11)
                    .HasColumnName("intptlat");

                entity.Property(e => e.Intptlon)
                    .HasMaxLength(12)
                    .HasColumnName("intptlon");

                entity.Property(e => e.Mtfcc)
                    .HasMaxLength(5)
                    .HasColumnName("mtfcc");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("name");

                entity.Property(e => e.Statefp)
                    .HasMaxLength(2)
                    .HasColumnName("statefp");

                entity.Property(e => e.Tractce)
                    .HasMaxLength(6)
                    .HasColumnName("tractce");

                entity.Property(e => e.Uace)
                    .HasMaxLength(5)
                    .HasColumnName("uace");

                entity.Property(e => e.Ur)
                    .HasMaxLength(1)
                    .HasColumnName("ur");
            });

            modelBuilder.Entity<Tract>(entity =>
            {
                entity.ToTable("tract", "tiger");

                entity.Property(e => e.TractId)
                    .HasMaxLength(11)
                    .HasColumnName("tract_id");

                entity.Property(e => e.Aland).HasColumnName("aland");

                entity.Property(e => e.Awater).HasColumnName("awater");

                entity.Property(e => e.Countyfp)
                    .HasMaxLength(3)
                    .HasColumnName("countyfp");

                entity.Property(e => e.Funcstat)
                    .HasMaxLength(1)
                    .HasColumnName("funcstat");

                entity.Property(e => e.Gid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("gid");

                entity.Property(e => e.Intptlat)
                    .HasMaxLength(11)
                    .HasColumnName("intptlat");

                entity.Property(e => e.Intptlon)
                    .HasMaxLength(12)
                    .HasColumnName("intptlon");

                entity.Property(e => e.Mtfcc)
                    .HasMaxLength(5)
                    .HasColumnName("mtfcc");

                entity.Property(e => e.Name)
                    .HasMaxLength(7)
                    .HasColumnName("name");

                entity.Property(e => e.Namelsad)
                    .HasMaxLength(20)
                    .HasColumnName("namelsad");

                entity.Property(e => e.Statefp)
                    .HasMaxLength(2)
                    .HasColumnName("statefp");

                entity.Property(e => e.Tractce)
                    .HasMaxLength(6)
                    .HasColumnName("tractce");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("user", "assignment4");

                entity.Property(e => e.BirthYear).HasColumnName("birthYear");

                entity.Property(e => e.City)
                    .HasColumnType("character varying")
                    .HasColumnName("city");

                entity.Property(e => e.Column9).HasColumnName("column_9");

                entity.Property(e => e.Domain)
                    .HasColumnType("character varying")
                    .HasColumnName("domain");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Password)
                    .HasColumnType("character varying")
                    .HasColumnName("password");

                entity.Property(e => e.Role)
                    .HasColumnType("character varying")
                    .HasColumnName("role");

                entity.Property(e => e.SecurityLevel).HasColumnName("securityLevel");

                entity.Property(e => e.Username)
                    .HasColumnType("character varying")
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Zcta5>(entity =>
            {
                entity.HasKey(e => new { e.Zcta5ce, e.Statefp })
                    .HasName("pk_tiger_zcta5_zcta5ce");

                entity.ToTable("zcta5", "tiger");

                entity.HasIndex(e => e.Gid, "uidx_tiger_zcta5_gid")
                    .IsUnique();

                entity.Property(e => e.Zcta5ce)
                    .HasMaxLength(5)
                    .HasColumnName("zcta5ce");

                entity.Property(e => e.Statefp)
                    .HasMaxLength(2)
                    .HasColumnName("statefp");

                entity.Property(e => e.Aland).HasColumnName("aland");

                entity.Property(e => e.Awater).HasColumnName("awater");

                entity.Property(e => e.Classfp)
                    .HasMaxLength(2)
                    .HasColumnName("classfp");

                entity.Property(e => e.Funcstat)
                    .HasMaxLength(1)
                    .HasColumnName("funcstat");

                entity.Property(e => e.Gid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("gid");

                entity.Property(e => e.Intptlat)
                    .HasMaxLength(11)
                    .HasColumnName("intptlat");

                entity.Property(e => e.Intptlon)
                    .HasMaxLength(12)
                    .HasColumnName("intptlon");

                entity.Property(e => e.Mtfcc)
                    .HasMaxLength(5)
                    .HasColumnName("mtfcc");

                entity.Property(e => e.Partflg)
                    .HasMaxLength(1)
                    .HasColumnName("partflg");
            });

            modelBuilder.Entity<ZipLookup>(entity =>
            {
                entity.HasKey(e => e.Zip)
                    .HasName("zip_lookup_pkey");

                entity.ToTable("zip_lookup", "tiger");

                entity.Property(e => e.Zip)
                    .ValueGeneratedNever()
                    .HasColumnName("zip");

                entity.Property(e => e.Cnt).HasColumnName("cnt");

                entity.Property(e => e.CoCode).HasColumnName("co_code");

                entity.Property(e => e.County)
                    .HasMaxLength(90)
                    .HasColumnName("county");

                entity.Property(e => e.Cousub)
                    .HasMaxLength(90)
                    .HasColumnName("cousub");

                entity.Property(e => e.CsCode).HasColumnName("cs_code");

                entity.Property(e => e.PlCode).HasColumnName("pl_code");

                entity.Property(e => e.Place)
                    .HasMaxLength(90)
                    .HasColumnName("place");

                entity.Property(e => e.StCode).HasColumnName("st_code");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .HasColumnName("state");
            });

            modelBuilder.Entity<ZipLookupAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zip_lookup_all", "tiger");

                entity.Property(e => e.Cnt).HasColumnName("cnt");

                entity.Property(e => e.CoCode).HasColumnName("co_code");

                entity.Property(e => e.County)
                    .HasMaxLength(90)
                    .HasColumnName("county");

                entity.Property(e => e.Cousub)
                    .HasMaxLength(90)
                    .HasColumnName("cousub");

                entity.Property(e => e.CsCode).HasColumnName("cs_code");

                entity.Property(e => e.PlCode).HasColumnName("pl_code");

                entity.Property(e => e.Place)
                    .HasMaxLength(90)
                    .HasColumnName("place");

                entity.Property(e => e.StCode).HasColumnName("st_code");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .HasColumnName("state");

                entity.Property(e => e.Zip).HasColumnName("zip");
            });

            modelBuilder.Entity<ZipLookupBase>(entity =>
            {
                entity.HasKey(e => e.Zip)
                    .HasName("zip_lookup_base_pkey");

                entity.ToTable("zip_lookup_base", "tiger");

                entity.Property(e => e.Zip)
                    .HasMaxLength(5)
                    .HasColumnName("zip");

                entity.Property(e => e.City)
                    .HasMaxLength(90)
                    .HasColumnName("city");

                entity.Property(e => e.County)
                    .HasMaxLength(90)
                    .HasColumnName("county");

                entity.Property(e => e.State)
                    .HasMaxLength(40)
                    .HasColumnName("state");

                entity.Property(e => e.Statefp)
                    .HasMaxLength(2)
                    .HasColumnName("statefp");
            });

            modelBuilder.Entity<ZipState>(entity =>
            {
                entity.HasKey(e => new { e.Zip, e.Stusps })
                    .HasName("zip_state_pkey");

                entity.ToTable("zip_state", "tiger");

                entity.Property(e => e.Zip)
                    .HasMaxLength(5)
                    .HasColumnName("zip");

                entity.Property(e => e.Stusps)
                    .HasMaxLength(2)
                    .HasColumnName("stusps");

                entity.Property(e => e.Statefp)
                    .HasMaxLength(2)
                    .HasColumnName("statefp");
            });

            modelBuilder.Entity<ZipStateLoc>(entity =>
            {
                entity.HasKey(e => new { e.Zip, e.Stusps, e.Place })
                    .HasName("zip_state_loc_pkey");

                entity.ToTable("zip_state_loc", "tiger");

                entity.Property(e => e.Zip)
                    .HasMaxLength(5)
                    .HasColumnName("zip");

                entity.Property(e => e.Stusps)
                    .HasMaxLength(2)
                    .HasColumnName("stusps");

                entity.Property(e => e.Place)
                    .HasMaxLength(100)
                    .HasColumnName("place");

                entity.Property(e => e.Statefp)
                    .HasMaxLength(2)
                    .HasColumnName("statefp");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
