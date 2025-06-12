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
 * Do not modify this file. This file is generated from the ssm-sap-2018-05-10.normal.json service model.
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
    /// Container for the parameters to the RegisterApplication operation.
    /// Register an SAP application with AWS Systems Manager for SAP. You must meet the following
    /// requirements before registering. 
    /// 
    ///  
    /// <para>
    /// The SAP application you want to register with AWS Systems Manager for SAP is running
    /// on Amazon EC2.
    /// </para>
    ///  
    /// <para>
    /// AWS Systems Manager Agent must be setup on an Amazon EC2 instance along with the required
    /// IAM permissions.
    /// </para>
    ///  
    /// <para>
    /// Amazon EC2 instance(s) must have access to the secrets created in AWS Secrets Manager
    /// to manage SAP applications and components.
    /// </para>
    /// </summary>
    public partial class RegisterApplicationRequest : AmazonSsmSapRequest
    {
        private string _applicationId;
        private ApplicationType _applicationType;
        private List<ComponentInfo> _componentsInfo = AWSConfigs.InitializeCollections ? new List<ComponentInfo>() : null;
        private List<ApplicationCredential> _credentials = AWSConfigs.InitializeCollections ? new List<ApplicationCredential>() : null;
        private string _databaseArn;
        private List<string> _instances = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _sapInstanceNumber;
        private string _sid;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=60)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationType. 
        /// <para>
        /// The type of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ApplicationType ApplicationType
        {
            get { return this._applicationType; }
            set { this._applicationType = value; }
        }

        // Check to see if ApplicationType property is set
        internal bool IsSetApplicationType()
        {
            return this._applicationType != null;
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<ComponentInfo> ComponentsInfo
        {
            get { return this._componentsInfo; }
            set { this._componentsInfo = value; }
        }

        // Check to see if ComponentsInfo property is set
        internal bool IsSetComponentsInfo()
        {
            return this._componentsInfo != null && (this._componentsInfo.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// The credentials of the SAP application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<ApplicationCredential> Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }

        // Check to see if Credentials property is set
        internal bool IsSetCredentials()
        {
            return this._credentials != null && (this._credentials.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DatabaseArn. 
        /// <para>
        /// The Amazon Resource Name of the SAP HANA database.
        /// </para>
        /// </summary>
        public string DatabaseArn
        {
            get { return this._databaseArn; }
            set { this._databaseArn = value; }
        }

        // Check to see if DatabaseArn property is set
        internal bool IsSetDatabaseArn()
        {
            return this._databaseArn != null;
        }

        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        /// The Amazon EC2 instances on which your SAP application is running.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> Instances
        {
            get { return this._instances; }
            set { this._instances = value; }
        }

        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this._instances != null && (this._instances.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SapInstanceNumber. 
        /// <para>
        /// The SAP instance number of the application.
        /// </para>
        /// </summary>
        public string SapInstanceNumber
        {
            get { return this._sapInstanceNumber; }
            set { this._sapInstanceNumber = value; }
        }

        // Check to see if SapInstanceNumber property is set
        internal bool IsSetSapInstanceNumber()
        {
            return this._sapInstanceNumber != null;
        }

        /// <summary>
        /// Gets and sets the property Sid. 
        /// <para>
        /// The System ID of the application.
        /// </para>
        /// </summary>
        public string Sid
        {
            get { return this._sid; }
            set { this._sid = value; }
        }

        // Check to see if Sid property is set
        internal bool IsSetSid()
        {
            return this._sid != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to be attached to the SAP application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}