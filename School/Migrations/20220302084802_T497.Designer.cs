﻿// <auto-generated />
using System;
using ACM.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ACM.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20220302084802_T497")]
    partial class T497
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ACM.Models.AccountDataModelFactory.LinkUserRole", b =>
                {
                    b.Property<Guid>("LinkUserRoleID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedUserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("EditDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EditUserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserRoleID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LinkUserRoleID");

                    b.HasIndex("UserID");

                    b.HasIndex("UserRoleID");

                    b.ToTable("LinkUserRole");
                });

            modelBuilder.Entity("ACM.Models.AccountDataModelFactory.TemporaryTokensType", b =>
                {
                    b.Property<Guid>("TemporaryTokensTypeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TemporaryTokensTypeID");

                    b.ToTable("TemporaryTokensType");
                });

            modelBuilder.Entity("ACM.Models.AccountDataModelFactory.User", b =>
                {
                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("AcceptTermsAndConditions")
                        .HasColumnType("bit");

                    b.Property<Guid?>("AcmAccessRoleID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CellphoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CountryID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedUserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EditDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EditUserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IDNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdminApproved")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEmailVerified")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSuspended")
                        .HasColumnType("bit");

                    b.Property<Guid?>("LanguageCultureID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("LoginTries")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ProvinceID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("ReceiveEmailNotification")
                        .HasColumnType("bit");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Timezone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.HasIndex("AcmAccessRoleID");

                    b.HasIndex("CountryID");

                    b.HasIndex("LanguageCultureID");

                    b.HasIndex("ProvinceID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ACM.Models.AccountDataModelFactory.UserRole", b =>
                {
                    b.Property<Guid>("UserRoleID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserRoleID");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("ACM.Models.AccountDataModelFactory.UserTemporaryToken", b =>
                {
                    b.Property<Guid>("UserTemporaryTokenID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedUserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("EditDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("EditUserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TemporaryTokensTypeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TokenExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserTemporaryTokenID");

                    b.HasIndex("TemporaryTokensTypeID");

                    b.HasIndex("UserID");

                    b.ToTable("UserTemporaryToken");
                });

            modelBuilder.Entity("ACM.Models.ACMDataModelFactory.AcmAccessRole", b =>
                {
                    b.Property<Guid>("AcmAccessRoleID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AcmAccessRoleID");

                    b.ToTable("AcmAccessRoles");
                });

            modelBuilder.Entity("ACM.Models.ACMDataModelFactory.AcmRole", b =>
                {
                    b.Property<Guid>("AcmRoleID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AcmRoleID");

                    b.ToTable("AcmRoles");
                });

            modelBuilder.Entity("ACM.Models.ACMDataModelFactory.LinkAcmAccessRoleAcmRole", b =>
                {
                    b.Property<Guid>("LinkAcmAccessRoleAcmRoleID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AcmAccessRoleID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AcmRoleID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LinkAcmAccessRoleAcmRoleID");

                    b.HasIndex("AcmAccessRoleID");

                    b.HasIndex("AcmRoleID");

                    b.ToTable("LinkAcmAccessRoleAcmRoles");
                });

            modelBuilder.Entity("ACM.Models.Auditing.AuditAccountDataModelFactory.LinkUserRoleAudit", b =>
                {
                    b.Property<Guid>("LinkUserRoleAuditID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedUserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("EditDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EditUserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LinkUserRoleID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserRoleID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ValidFromDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ValidToDate")
                        .HasColumnType("datetime2");

                    b.HasKey("LinkUserRoleAuditID");

                    b.ToTable("LinkUserRoleAudit");
                });

            modelBuilder.Entity("ACM.Models.Auditing.AuditAccountDataModelFactory.UserAudit", b =>
                {
                    b.Property<Guid>("UserAuditID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("AcceptTermsAndConditions")
                        .HasColumnType("bit");

                    b.Property<string>("CellphoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CountryID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedUserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EditDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EditUserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IDNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsEmailVerified")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSuspended")
                        .HasColumnType("bit");

                    b.Property<Guid?>("LanguageCultureID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("LoginTries")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Timezone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ValidFromDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ValidToDate")
                        .HasColumnType("datetime2");

                    b.HasKey("UserAuditID");

                    b.ToTable("UserAudit");
                });

            modelBuilder.Entity("ACM.Models.SystemModelFactory.ApplicationLog", b =>
                {
                    b.Property<Guid>("ApplicationLogID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Exception")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Level")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LogDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LogOriginator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ApplicationLogID");

                    b.HasIndex("UserID");

                    b.ToTable("ApplicationLog");
                });

            modelBuilder.Entity("ACM.Models.SystemModelFactory.Country", b =>
                {
                    b.Property<Guid>("CountryID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CallingCodePrefix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IDNumberValidationLength")
                        .HasColumnType("int");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<string>("IsoAlpha2Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IsoAlpha3Code")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryID");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("ACM.Models.SystemModelFactory.EmailTemplate", b =>
                {
                    b.Property<Guid>("EmailTemplateID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedUserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EditDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("EditUserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EventCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SMSTemplateBody")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TemplateBody")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TemplateBodyTags")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmailTemplateID");

                    b.ToTable("EmailTemplates");
                });

            modelBuilder.Entity("ACM.Models.SystemModelFactory.FAQ", b =>
                {
                    b.Property<Guid>("FAQID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Catergory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FAQID");

                    b.ToTable("FAQ");
                });

            modelBuilder.Entity("ACM.Models.SystemModelFactory.LanguageCulture", b =>
                {
                    b.Property<Guid>("LanguageCultureID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CultureNameCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LanguageCultureID");

                    b.ToTable("LanguageCultures");
                });

            modelBuilder.Entity("ACM.Models.SystemModelFactory.LocalizationValue", b =>
                {
                    b.Property<Guid>("LocalizationValueID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("KeyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("LanguageCultureID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocalizationValueID");

                    b.HasIndex("LanguageCultureID");

                    b.ToTable("LocalizationValues");
                });

            modelBuilder.Entity("ACM.Models.SystemModelFactory.Province", b =>
                {
                    b.Property<Guid>("ProvinceID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CountryID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProvIsoCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProvinceID");

                    b.HasIndex("CountryID");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("ACM.Models.SystemModelFactory.SystemConfiguration", b =>
                {
                    b.Property<Guid>("SystemConfigurationID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConfigValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedUserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EditDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("EditUserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EventCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SystemConfigurationID");

                    b.ToTable("SystemConfiguration");
                });

            modelBuilder.Entity("ACM.Models.UserModelFactory.CalendarEvent", b =>
                {
                    b.Property<Guid>("CalendarEventID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CalendarEventTypeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ColorCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedUserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EditDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("EditUserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("EnableReminder")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAllDay")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CalendarEventID");

                    b.HasIndex("CalendarEventTypeID");

                    b.HasIndex("UserID");

                    b.ToTable("CalendarEvents");
                });

            modelBuilder.Entity("ACM.Models.UserModelFactory.CalendarEventMetaFieldValue", b =>
                {
                    b.Property<Guid>("CalendarEventMetaFieldValueID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CalendarEventID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CalendarEventTypeMetaFieldID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MetaValue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CalendarEventMetaFieldValueID");

                    b.HasIndex("CalendarEventID");

                    b.HasIndex("CalendarEventTypeMetaFieldID");

                    b.ToTable("CalendarEventMetaFieldValues");
                });

            modelBuilder.Entity("ACM.Models.UserModelFactory.CalendarEventType", b =>
                {
                    b.Property<Guid>("CalendarEventTypeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ColorCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CalendarEventTypeID");

                    b.HasIndex("UserID");

                    b.ToTable("CalendarEventTypes");
                });

            modelBuilder.Entity("ACM.Models.UserModelFactory.CalendarEventTypeMetaField", b =>
                {
                    b.Property<Guid>("CalendarEventTypeMetaFieldID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CalendarEventTypeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CalendarEventTypeMetaFieldID");

                    b.HasIndex("CalendarEventTypeID");

                    b.ToTable("CalendarEventTypeMetaField");
                });

            modelBuilder.Entity("ACM.Models.UserModelFactory.UserInAppNotification", b =>
                {
                    b.Property<Guid>("UserInAppNotificationID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ActionCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ActionID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedUserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("EditDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("EditUserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsRead")
                        .HasColumnType("bit");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserInAppNotificationID");

                    b.HasIndex("UserID");

                    b.ToTable("UserInAppNotifications");
                });

            modelBuilder.Entity("ACM.Models.UserModelFactory.UserPaymentTransaction", b =>
                {
                    b.Property<Guid>("UserPaymentTransactionID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AmountFee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AmountGross")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AmountNet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PFPaymentID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PFPaymentStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PFReferenceID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentRefID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TransactionType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserPaymentTransactionID");

                    b.ToTable("UserPaymentTransactions");
                });

            modelBuilder.Entity("ACM.Models.AccountDataModelFactory.LinkUserRole", b =>
                {
                    b.HasOne("ACM.Models.AccountDataModelFactory.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ACM.Models.AccountDataModelFactory.UserRole", "UserRole")
                        .WithMany()
                        .HasForeignKey("UserRoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("UserRole");
                });

            modelBuilder.Entity("ACM.Models.AccountDataModelFactory.User", b =>
                {
                    b.HasOne("ACM.Models.ACMDataModelFactory.AcmAccessRole", "AcmAccessRole")
                        .WithMany()
                        .HasForeignKey("AcmAccessRoleID");

                    b.HasOne("ACM.Models.SystemModelFactory.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryID");

                    b.HasOne("ACM.Models.SystemModelFactory.LanguageCulture", "LanguageCulture")
                        .WithMany()
                        .HasForeignKey("LanguageCultureID");

                    b.HasOne("ACM.Models.SystemModelFactory.Province", "Province")
                        .WithMany()
                        .HasForeignKey("ProvinceID");

                    b.Navigation("AcmAccessRole");

                    b.Navigation("Country");

                    b.Navigation("LanguageCulture");

                    b.Navigation("Province");
                });

            modelBuilder.Entity("ACM.Models.AccountDataModelFactory.UserTemporaryToken", b =>
                {
                    b.HasOne("ACM.Models.AccountDataModelFactory.TemporaryTokensType", "TemporaryTokensType")
                        .WithMany()
                        .HasForeignKey("TemporaryTokensTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ACM.Models.AccountDataModelFactory.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TemporaryTokensType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ACM.Models.ACMDataModelFactory.LinkAcmAccessRoleAcmRole", b =>
                {
                    b.HasOne("ACM.Models.ACMDataModelFactory.AcmAccessRole", "AcmAccessRole")
                        .WithMany()
                        .HasForeignKey("AcmAccessRoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ACM.Models.ACMDataModelFactory.AcmRole", "AcmRole")
                        .WithMany()
                        .HasForeignKey("AcmRoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AcmAccessRole");

                    b.Navigation("AcmRole");
                });

            modelBuilder.Entity("ACM.Models.SystemModelFactory.ApplicationLog", b =>
                {
                    b.HasOne("ACM.Models.AccountDataModelFactory.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ACM.Models.SystemModelFactory.LocalizationValue", b =>
                {
                    b.HasOne("ACM.Models.SystemModelFactory.LanguageCulture", "LanguageCulture")
                        .WithMany()
                        .HasForeignKey("LanguageCultureID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LanguageCulture");
                });

            modelBuilder.Entity("ACM.Models.SystemModelFactory.Province", b =>
                {
                    b.HasOne("ACM.Models.SystemModelFactory.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryID");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("ACM.Models.UserModelFactory.CalendarEvent", b =>
                {
                    b.HasOne("ACM.Models.UserModelFactory.CalendarEventType", "CalendarEventType")
                        .WithMany()
                        .HasForeignKey("CalendarEventTypeID");

                    b.HasOne("ACM.Models.AccountDataModelFactory.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CalendarEventType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ACM.Models.UserModelFactory.CalendarEventMetaFieldValue", b =>
                {
                    b.HasOne("ACM.Models.UserModelFactory.CalendarEvent", "CalendarEvent")
                        .WithMany()
                        .HasForeignKey("CalendarEventID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ACM.Models.UserModelFactory.CalendarEventTypeMetaField", "CalendarEventTypeMetaField")
                        .WithMany()
                        .HasForeignKey("CalendarEventTypeMetaFieldID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CalendarEvent");

                    b.Navigation("CalendarEventTypeMetaField");
                });

            modelBuilder.Entity("ACM.Models.UserModelFactory.CalendarEventType", b =>
                {
                    b.HasOne("ACM.Models.AccountDataModelFactory.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ACM.Models.UserModelFactory.CalendarEventTypeMetaField", b =>
                {
                    b.HasOne("ACM.Models.UserModelFactory.CalendarEventType", "CalendarEventType")
                        .WithMany()
                        .HasForeignKey("CalendarEventTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CalendarEventType");
                });

            modelBuilder.Entity("ACM.Models.UserModelFactory.UserInAppNotification", b =>
                {
                    b.HasOne("ACM.Models.AccountDataModelFactory.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
