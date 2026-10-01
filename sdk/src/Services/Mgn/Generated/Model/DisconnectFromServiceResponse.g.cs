/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// This is the response object from the DisconnectFromService operation.
    /// </summary>
    public partial class DisconnectFromServiceResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApplicationID. 
        /// <para>
        /// Source server application ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 21, Max = 21)]
        public string ApplicationID { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationID property is set.
        /// </summary>
        internal bool IsSetApplicationID() => this.ApplicationID != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Source server ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ConnectorAction. 
        /// <para>
        /// Source Server connector action.
        /// </para>
        /// </summary>
        public SourceServerConnectorAction ConnectorAction { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorAction property is set.
        /// </summary>
        internal bool IsSetConnectorAction() => this.ConnectorAction != null;

        /// <summary>
        /// Gets and sets the property DataReplicationInfo. 
        /// <para>
        /// Source server data replication info.
        /// </para>
        /// </summary>
        public DataReplicationInfo DataReplicationInfo { get; set; }

        /// <summary>
        /// Checks to see if the DataReplicationInfo property is set.
        /// </summary>
        internal bool IsSetDataReplicationInfo() => this.DataReplicationInfo != null;

        /// <summary>
        /// Gets and sets the property FqdnForActionFramework. 
        /// <para>
        /// Source server fqdn for action framework.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string FqdnForActionFramework { get; set; }

        /// <summary>
        /// Checks to see if the FqdnForActionFramework property is set.
        /// </summary>
        internal bool IsSetFqdnForActionFramework() => this.FqdnForActionFramework != null;

        /// <summary>
        /// Gets and sets the property IsArchived. 
        /// <para>
        /// Source server archived status.
        /// </para>
        /// </summary>
        public bool? IsArchived { get; set; }

        /// <summary>
        /// Checks to see if the IsArchived property is set.
        /// </summary>
        internal bool IsSetIsArchived() => this.IsArchived.HasValue;

        /// <summary>
        /// Gets and sets the property LaunchedInstance. 
        /// <para>
        /// Source server launched instance.
        /// </para>
        /// </summary>
        public LaunchedInstance LaunchedInstance { get; set; }

        /// <summary>
        /// Checks to see if the LaunchedInstance property is set.
        /// </summary>
        internal bool IsSetLaunchedInstance() => this.LaunchedInstance != null;

        /// <summary>
        /// Gets and sets the property LifeCycle. 
        /// <para>
        /// Source server lifecycle state.
        /// </para>
        /// </summary>
        public LifeCycle LifeCycle { get; set; }

        /// <summary>
        /// Checks to see if the LifeCycle property is set.
        /// </summary>
        internal bool IsSetLifeCycle() => this.LifeCycle != null;

        /// <summary>
        /// Gets and sets the property ReplicationType. 
        /// <para>
        /// Source server replication type.
        /// </para>
        /// </summary>
        public ReplicationType ReplicationType { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationType property is set.
        /// </summary>
        internal bool IsSetReplicationType() => this.ReplicationType != null;

        /// <summary>
        /// Gets and sets the property SourceProperties. 
        /// <para>
        /// Source server properties.
        /// </para>
        /// </summary>
        public SourceProperties SourceProperties { get; set; }

        /// <summary>
        /// Checks to see if the SourceProperties property is set.
        /// </summary>
        internal bool IsSetSourceProperties() => this.SourceProperties != null;

        /// <summary>
        /// Gets and sets the property SourceServerID. 
        /// <para>
        /// Source server ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 19)]
        public string SourceServerID { get; set; }

        /// <summary>
        /// Checks to see if the SourceServerID property is set.
        /// </summary>
        internal bool IsSetSourceServerID() => this.SourceServerID != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Source server Tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserProvidedID. 
        /// <para>
        /// Source server user provided ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string UserProvidedID { get; set; }

        /// <summary>
        /// Checks to see if the UserProvidedID property is set.
        /// </summary>
        internal bool IsSetUserProvidedID() => this.UserProvidedID != null;

        /// <summary>
        /// Gets and sets the property VcenterClientID. 
        /// <para>
        /// Source server vCenter client id.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 21, Max = 21)]
        public string VcenterClientID { get; set; }

        /// <summary>
        /// Checks to see if the VcenterClientID property is set.
        /// </summary>
        internal bool IsSetVcenterClientID() => this.VcenterClientID != null;
    }
}
