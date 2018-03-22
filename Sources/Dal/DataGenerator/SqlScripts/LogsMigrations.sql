﻿USE [{0}]
CREATE TABLE [dbo].[__MigrationHistory] (
    [MigrationId] [nvarchar](150) NOT NULL,
    [ContextKey] [nvarchar](300) NOT NULL,
    [Model] [varbinary](max) NOT NULL,
    [ProductVersion] [nvarchar](32) NOT NULL,
    CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY ([MigrationId], [ContextKey])
)
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'201802140517394_vasiliy.stan_7c2229cb57c14bf3bfb07099cc32c239', N'Dal.Migrations.Configuration',  0x1F8B0800000000000400CD55CB6EDB3010BC17E83F08BCC7B49D4B1BC809523B2902C47151B9B933D24A21CA57B5AB20FAB61EFA49FD85AE6CC9AF348E13F4D023C9E5ECECEC70F9FBE7AFF8ECD19AE8014AD4DE8DC4A0D71711B8D467DA152351517EF4419C9DBE7F175F64F631BAEDE28E9B38BEE97024EE89C2899498DE8355D8B33A2D3DFA9C7AA9B752655E0EFBFD8F723090C01082B1A228FE5A39D216160B5E8EBD4B2150A5CCD46760B0DDE79364811ADD280B18540A23716103D5223A375A71F2044C2E22E59C27454CEDE41B4242A5774512784399791D80E37265105ACA27EBF043D9F7870D7BB9BED841A51592B7AF041C1CB772C8DDEB6F1255ACE462C12E5858AA595052DA41B9506E24AE7D81CD1E3C92887693369A8D4DD92A4565C542C9750BE4B2075DAFE433CD8AA72A0476CD46F3DA9D2859766E7C94BCBE3EBBC49029EE2B7395897CA90AD839E5D4CCF45297481345EA4E35561867F649D8964C9B12B4F82B0D766A8DDBBC2FBBF70991658888BE94FE41670D89A44602DB6B027AC90F33361A1CAD03A6CAE91C90E6FE3BB0DDD84DC39DD7F0FF38532266E6007BFEA53D7B0CF854EC586E0E947802A80B46DF182F0ED2A68A35681773E572CFD20628A94E8036B97621DD714B760AA432E6795E92CE554A7C9C0222DB4144B7CA548B197507D9959B55142A3A47047B67EAED9AF6E75FBCB26DCEF12C342BFC1725304DCD25C0CC7DAAB4C956BC2F9753521E00D1B4EC33F0FEC21D3C7219AEA8574837DE1D08D4CA3781002E63A7CFC106C3603873897A80B770E379760D854AEBEECD3C0FF27223B6658F275A15A5B2D862ACEF379FA46C7EC9D33F6BF277F357070000 , N'6.2.0-61023')
GO

CREATE TABLE [dbo].[FrontendWebLogs] (
    [Id] [int] NOT NULL IDENTITY,
    [Date] [datetime2](7) NOT NULL,
    [Thread] [nvarchar](255) NOT NULL,
    [Level] [nvarchar](50) NOT NULL,
    [Logger] [nvarchar](255) NOT NULL,
    [Message] [nvarchar](4000) NOT NULL,
    [Exception] [nvarchar](2000) NOT NULL,
    [RowVersion] rowversion NOT NULL,
    CONSTRAINT [PK_dbo.FrontendWebLogs] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[Seeding] (
    [Id] [int] NOT NULL IDENTITY,
    [IsSeed] [bit] NOT NULL,
    CONSTRAINT [PK_dbo.Seeding] PRIMARY KEY ([Id])
)
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'201802140522109_vasiliy.stan_6714e9077a3d4050997998650cf8784c', N'Dal.Migrations.Configuration',  0x1F8B0800000000000400ED59CD6EE33610BE17E83B083A672DC769D06D20EF22EB2445D03809A2647BA6A5B14294225592F2DACFB6873E525FA143FD5B921DD94E82A2287CB1479C6F7E38BFF2DFDFFF723F2F23662D402A2AF8D83E1E0C6D0BB82F02CAC3B19DE8F9878FF6E74F3FFEE05E06D1D2FA5A9C3B31E79093ABB1FDAC757CE638CA7F8688A841447D299498EB812F228704C2190D87BF38C7C70E20848D5896E53E245CD308D21FF87322B80FB14E089B8A0098CAE9F8C44B51AD5B12818A890F63FB8230DB3A6794A0680FD8DCB608E742138D8A9D3D29F0B4143CF4622410F6B88A01CFCD0953902B7C561DEFABFB706474772AC602CA4F9416D18E80C727B9339C26FB5E2EB54B67A1BB2ED1AD7A65AC4E5D36B6AFD0191A78F03BCC6E44A852F7DA5653F0D98449C3947A77D0C57364E193A33200304ECCE7C89A244C2712C61C122DCD89FB64C6A8FF1BAC1EC51FC0C73C61ACAE21EA88CFD60848BA972206A9570F30CFF5BE0E6CCB59E7739A8C255B8D27B3E29AEB93916DDDA2703263500640CD624F0B09BF0207493404F7446B90DC6040EAC296F486AC0BE42AA499EF8F18CD1D02B7833C3E4B20A5D218B89874B63525CB1BE0A17E1EDBA3D353DBBAA24B080A4A8EFBC429E628326999EC2EF70616260A368A3D1DBE8954118620DFDFDA29284542D822F8A7E1F04D2CBE5C9AAA9626F666A3DF48F683F896276B21FC0BE54462609B629B4889557E354DF153E16B4A7DECD6688F7C9A88284E3434B2D975AA42B5B57C790041AF9A551EFCBF50356429E39A3206846040F80BD1B4FD7A307E34A1A84F95D7CAD060A93B6E093B727E512A8FE47575334C0F7477C3B2AD4A95ACDF77B6A796179AB0C60969EAB5E06A21D6E583D2DA6A2671B2A1A4185E9C0DD38B3B25718C326BD34C4EB1BC6C94997CF0766FF95186E1F8AAA3F397DA9692307AB0F8359E9ABC0CE08A4AA5B179911931113009A2D6B1FADD6E707021A9FBFA9A0954B9BFE033DF8B9EDA3D7B34412A475EA16D11E6416A26942A6D187B5A30E97C4918911DF939112C89F8A61CDFC69D8D0675FE8CD21FA1980BEA1805AD3F4ADEE5EB203969078CBC67AF81E4B4FE286507AEC394C4FE38B57E5A47AA91FB63D5FB631DAC4E6FA3B94E23F29AF1EDB402BCD11B9A79D32BAB8AEAB56B3655B56DF714DAC2FB36795374AA35849CF6CE37D12AFECD23A5F4B209348ABD9B17DE97F7D95625CE8ED816BA6741035385BD95D2100DCC8181F7279B308AF65607A684D339289D0D3238511E8F1A1BF2BF675B75940AD81E2BEBBB4F66D478F8C5D96BC7A1BCBE3506F8DDBC0319998B049F662F567E3E7089E40B22FD6722DB8BD5213B6227AAD9120F5A015F4DD7C686D7899BED78872E70DD2AEF03DDDECFA4F8B628282F6E5307CCEF9DEBD57F23BFD6979D19D5AFBAE8B467E69D56997CC9E8B9CF645D00CBC44CA03D9905ADDDA8C7D2B3496AED5997A8725FDA73276AB73FD7A9BFF4752F40D1B08230AF8039F826D72AD0E2CC359F8BE2A6D1BABA46C5915645D0040B2C39979ACE89AFF1B18F4522B5E82B6189C9ED6806C135BF4B34A6D4B95210CDD8DA36ED3ADBE5A78BDFBACEEE5D5A2DD46B98806A52D323EEF89784B2A0D4FBAA238C37409880CDB30BB5F2B4C9B2705522DD0ADE132877DF05C4187D989B8F10C50CC1D41DF7C802F6D1ED49C10D84C45F1553CC6690972F62DDEDEE0525A12491CA312A7EF3478663FEC9F8F40F6E282CC9FB180000 , N'6.2.0-61023')
GO

CREATE TABLE [dbo].[IdentityRepositoryTestsConsoleLogs] (
    [Id] [int] NOT NULL IDENTITY,
    [Date] [datetime2](7) NOT NULL,
    [Thread] [nvarchar](255) NOT NULL,
    [Level] [nvarchar](50) NOT NULL,
    [Logger] [nvarchar](255) NOT NULL,
    [Message] [nvarchar](4000) NOT NULL,
    [Exception] [nvarchar](2000) NOT NULL,
    [RowVersion] rowversion NOT NULL,
    CONSTRAINT [PK_dbo.IdentityRepositoryTestsConsoleLogs] PRIMARY KEY ([Id])
)
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'201802172149590_vasiliy.stan_8545639ffb864cb68b5d4d1baf5943ba', N'Logs.Migrations.Configuration',  0x1F8B0800000000000400ED5ACD6EE3460CBE17E83B083A672DC769D06D20EF22EB2445D0380922677B1E4BB433A834A3CE8CBCF6B3EDA18FD4572847FFD68F2DDB49DA02862F3235FCC8E1901C92F6DFDFFFB23F2F03DF58809094B3A179DAEB9B0630977B94CD8766A4661F3E9A9F3FFDF8837DED054BE36BB6EE4CAF434E2687E68B52E1856549F70502227B017505977CA67A2E0F2CE2716BD0EFFF629D9E5A801026621986FD1431450388BFE0D711672E842A22FE987BE0CB948E6F9C18D5B82701C890B83034EFF85C9AC6A54F09CA76C09F9906618C2BA250B38B67098E129CCD9D1009C49FAC42C07533E24B4835BE28967755BE3FD0CA5B056306E54652F16047C0D3B3D41A56957D2F9B9AB9B5D05ED76857B5D2BB8E6D36346FD0180A98F73B4CB5E562FB9A4655F0C5C8179A29316FAF89E9C4D08F27B90FA0ABE8CF89318A7C15091832889420B8EE319AFAD4FD0D5613FE07B0218B7CBFAC236A89EFD608487A143C04A1564F304B35BFF54CC35AE7B3AA8C395B8927D9C72D536703D3B847E164EA43EE02A53D3B8A0BF8151808A2C07B244A81601A036223D6A457645D2157264D3F4FD0A11B046E0699BC0820B9D2E8BA1877A63126CB3B6073F5323407E7E7A6714397E0659414F799510C53645222DA5DEE1D2CB41FB48A3DEFBF89543E9F8378FFDD8E414A32870D827FEAF7DF64C7D74B9DD8E2D06EDFF41BC97EE2DFD260CD847FA18C08746C9D6F232130D1AFC6317E2C7C4DA98FCD1AED114F231E8491824A34DB5691AA3626B02C1C9F20E492A288D504A492B805C97DE89ED33AE21CD3DC31CD1DD3DC31CDBD779A7300BC6E892C5F794C55555952DB26F7028E799DB02DFEB4F980D08314A1A84F11D9FAC650B0540DE784CD477A5432F5E57575134C0754736D6E1A852A496BD35888D7AC5085DD7ED33548EA7CCD6E11AE4F208EFC9A849287371D406EEAA2F9B392EE2FEB12AD9636D11E93304499A5B631A5184ED2338E3E38BBB756418261B9B2A1C3CAB5CD25A1C930F756DEEAB4E0C10D1552E1DD49A644BBDFC80B6ACBCA8ED562E04C52B3EF54A3B7307FC6A79F0B2F6E76AD0A4A61C91BDC5C801E12EF13729D5AFACB1A4CDCC9139F8886EC30E27E14B0B60CB3893B294DCAFC09A53B4256979431325A7794B4CA2883A4A41D30D29A610D24A57547C92B80324C4EEC8E53BACFCB48257277ACF2FD5C062BD3EB68B655F1BCAA835B350FAFDC4CD5C0E914561D72E7CE91D635B5EE1E7C7B231FE3712BC6311ED7B1FE9D78CCCA899D83AEA836760FAB0DBC6F133859E1BA8690D2DEF9286AE55875492E3D2FCB2AE5979D9642DB47F9B5DA2859621A689E05F5745DE4ACA482A0A717F49C3FFD914F71BFC58231617486292FE96BB0C53C1D547E1BF8EFCCE92D293D7F8F61FDBB376A545B786B2BB663975E1E2379F8AC7FFE19E883049726BF29FD7CE054892D88705F88A84F5A0E191A35A2EAB1D14133A157D3B532F269C44D863E874E749A55DE07BA3EB011FCDB22A36C1DAF1CD0CEEF31563E46DF31FA8ED1F7DAD1D75261FD6FE36B7DF238A5EA55A78EF519D24E73C574E8D671B898D4609826A61CF793ECA036A83C7802D9A65367CE2635BB0C3E3B8C2FDB742BBD6B929E4F3EF79C6ED6CB66DB2AFF4FC6BE0249E70584FED70C0357678902345B73CB663CF351DC5D59A36C492D9729825703B9148ACE88ABF0B58BE92DDED157E2473A2B0553F06ED943A430195C4A09C1D45F1BCADBD666F9F108775D67FB21CE73F235B6806A527DBB3DB02F11F5BD5CEF9B86006C81D0A196E605D4CA513A3FCC5739D23D671D8152F35D418871836E398120F4114C3E30872C601FDD9E25DCC19CB8ABACFB6907D97E10EB66B7AF28990B12C814A3E0C7AFE8C35EB0FCF40F226263CA2E260000 , N'6.2.0-61023')
GO