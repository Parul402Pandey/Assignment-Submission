using System;
using Scribe.Core.ConnectorApi;
using System.Linq;
using System.Collections.Generic;



namespace Scribe
{
    [ScribeConnector(
        ConnectorSettings.ConnectorTypeId,
        ConnectorSettings.Name,
        ConnectorSettings.Description,
        typeof(Connector),
        StandardConnectorSettings.SettingsUITypeName,
        StandardConnectorSettings.SettingsUIVersion,
        StandardConnectorSettings.ConnectionUITypeName,
        StandardConnectorSettings.ConnectionUIVersion,
        StandardConnectorSettings.XapFileName,
        new[] { "Scribe.Is.Source","Scribe.Is.Target","Scribe.IS2.Source", "Scribe.IS2.Target" },
        ConnectorSettings.SupportsCloud,ConnectorSettings.ConnectorVersion)]
    public class Connector : IConnector
    {
       public bool IsConnected
        {
            get;
        }

      public Guid ConnectorTypeId
        {
            get { return new Guid(ConnectorSettings.ConnectorTypeId); }
        }

     public   string PreConnect(IDictionary<string, string> properties)
        {
            throw new NotImplementedException();
        }

        public void Connect(IDictionary<string, string> properties)
        {

        }

       public  void Disconnect()
        {

        }

       public IMetadataProvider GetMetadataProvider()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DataEntity> ExecuteQuery(Scribe.Core.ConnectorApi.Query.Query query)
        {
            throw new NotImplementedException();
        }

      public Scribe.Core.ConnectorApi.Actions.OperationResult ExecuteOperation(Scribe.Core.ConnectorApi.Actions.OperationInput input)
        {
            throw new NotImplementedException();
        }

    public Scribe.Core.ConnectorApi.Actions.MethodResult ExecuteMethod(Scribe.Core.ConnectorApi.Actions.MethodInput input)
        {
            throw new NotImplementedException();
        }








    }
}
