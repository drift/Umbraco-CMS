﻿namespace Umbraco.Core.Persistence.Migrations.Upgrades.TargetVersionSixth
{
    [MigrationAttribute("6.0.0", 2)]
    public class UpdateCmsContentTypeTable : MigrationBase
    {
        public override void Up()
        {
            Alter.Table("cmsContentType").AddColumn("isContainer").AsBoolean().NotNullable().WithDefaultValue(0);

            Alter.Table("cmsContentType").AddColumn("allowAtRoot").AsBoolean().NotNullable().WithDefaultValue(0);
        }

        public override void Down()
        {
            Delete.Column("allowAtRoot").FromTable("cmsContentType");

            Delete.Column("isContainer").FromTable("cmsContentType");
        }
    }
}