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

namespace Amazon.SsmSap.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterApplication operation. Register an SAP
    /// application with AWS Systems Manager for SAP. You must meet the following requirements
    /// before registering. <para> The SAP application you want to register with AWS Systems
    /// Manager for SAP is running on Amazon EC2. </para> <para> AWS Systems Manager Agent
    /// must be setup on an Amazon EC2 instance along with the required IAM permissions. </para>
    /// <para> Amazon EC2 instance(s) must have access to the secrets created in AWS Secrets
    /// Manager to manage SAP applications and components. </para>
    /// </summary>
    public partial class RegisterApplicationRequest : AmazonSsmSapRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 60)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property ApplicationType. 
        /// <para>
        /// The type of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ApplicationType ApplicationType { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationType property is set.
        /// </summary>
        internal bool IsSetApplicationType() => this.ApplicationType != null;

        /// <summary>
        /// Gets and sets the property ComponentsInfo. 
        /// <para>
        /// This is an optional parameter for component details to which the SAP ABAP application
        /// is attached, such as Web Dispatcher.
        /// </para>
        ///  
        /// <para>
        /// This is an array of ApplicationComponent objects. You may input 0 to 5 items.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<ComponentInfo> ComponentsInfo { get; set; } = AWSConfigs.InitializeCollections ? new List<ComponentInfo>() : null;

        /// <summary>
        /// Checks to see if the ComponentsInfo property is set.
        /// </summary>
        internal bool IsSetComponentsInfo() => this.ComponentsInfo != null && (this.ComponentsInfo.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// The credentials of the SAP application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<ApplicationCredential> Credentials { get; set; } = AWSConfigs.InitializeCollections ? new List<ApplicationCredential>() : null;

        /// <summary>
        /// Checks to see if the Credentials property is set.
        /// </summary>
        internal bool IsSetCredentials() => this.Credentials != null && (this.Credentials.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DatabaseArn. 
        /// <para>
        /// The Amazon Resource Name of the SAP HANA database.
        /// </para>
        /// </summary>
        public string DatabaseArn { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseArn property is set.
        /// </summary>
        internal bool IsSetDatabaseArn() => this.DatabaseArn != null;

        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        /// The Amazon EC2 instances on which your SAP application is running.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<string> Instances { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Instances property is set.
        /// </summary>
        internal bool IsSetInstances() => this.Instances != null && (this.Instances.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SapInstanceNumber. 
        /// <para>
        /// The SAP instance number of the application.
        /// </para>
        /// </summary>
        public string SapInstanceNumber { get; set; }

        /// <summary>
        /// Checks to see if the SapInstanceNumber property is set.
        /// </summary>
        internal bool IsSetSapInstanceNumber() => this.SapInstanceNumber != null;

        /// <summary>
        /// Gets and sets the property Sid. 
        /// <para>
        /// The System ID of the application.
        /// </para>
        /// </summary>
        public string Sid { get; set; }

        /// <summary>
        /// Checks to see if the Sid property is set.
        /// </summary>
        internal bool IsSetSid() => this.Sid != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to be attached to the SAP application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
