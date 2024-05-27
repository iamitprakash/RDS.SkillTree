var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.RDS_SkillTree>("rds-skilltree");

builder.Build().Run();
