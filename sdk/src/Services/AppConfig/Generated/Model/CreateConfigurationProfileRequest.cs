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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// Container for the parameters to the CreateConfigurationProfile operation.
    /// Creates a configuration profile, which is information that enables AppConfig to access
    /// the configuration source. Valid configuration sources include the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Configuration data in YAML, JSON, and other formats stored in the AppConfig hosted
    /// configuration store
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Configuration data stored as objects in an Amazon Simple Storage Service (Amazon S3)
    /// bucket
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Pipelines stored in CodePipeline
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Secrets stored in Secrets Manager
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Standard and secure string parameters stored in Amazon Web Services Systems Manager
    /// Parameter Store
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Configuration data in SSM documents stored in the Systems Manager document store
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// A configuration profile includes the following information:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The URI location of the configuration data.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The Identity and Access Management (IAM) role that provides access to the configuration
    /// data.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A validator for the configuration data. Available validators include either a JSON
    /// Schema or an Amazon Web Services Lambda function.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/appconfig/latest/userguide/appconfig-creating-configuration-and-profile.html">Create
    /// a Configuration and a Configuration Profile</a> in the <i>AppConfig User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateConfigurationProfileRequest : AmazonAppConfigRequest
    {
        private string _applicationId;
        private string _description;
        private string _locationUri;
        private string _name;
        private string _retrievalRoleArn;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _type;
        private List<Validator> _validators = new List<Validator>();

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The application ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the configuration profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property LocationUri. 
        /// <para>
        /// A URI to locate the configuration. You can specify the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For the AppConfig hosted configuration store and for feature flags, specify <code>hosted</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For an Amazon Web Services Systems Manager Parameter Store parameter, specify either
        /// the parameter name in the format <code>ssm-parameter://&lt;parameter name&gt;</code>
        /// or the ARN.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For an Secrets Manager secret, specify the URI in the following format: <code>secrets-manager</code>://&lt;secret
        /// name&gt;.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For an Amazon S3 object, specify the URI in the following format: <code>s3://&lt;bucket&gt;/&lt;objectKey&gt;
        /// </code>. Here is an example: <code>s3://my-bucket/my-app/us-east-1/my-config.json</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For an SSM document, specify either the document name in the format <code>ssm-document://&lt;document
        /// name&gt;</code> or the Amazon Resource Name (ARN).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string LocationUri
        {
            get { return this._locationUri; }
            set { this._locationUri = value; }
        }

        // Check to see if LocationUri property is set
        internal bool IsSetLocationUri()
        {
            return this._locationUri != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the configuration profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RetrievalRoleArn. 
        /// <para>
        /// The ARN of an IAM role with permission to access the configuration at the specified
        /// <code>LocationUri</code>.
        /// </para>
        ///  <important> 
        /// <para>
        /// A retrieval role ARN is not required for configurations stored in the AppConfig hosted
        /// configuration store. It is required for all other sources that store your configuration.
        /// 
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string RetrievalRoleArn
        {
            get { return this._retrievalRoleArn; }
            set { this._retrievalRoleArn = value; }
        }

        // Check to see if RetrievalRoleArn property is set
        internal bool IsSetRetrievalRoleArn()
        {
            return this._retrievalRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata to assign to the configuration profile. Tags help organize and categorize
        /// your AppConfig resources. Each tag consists of a key and an optional value, both of
        /// which you define.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of configurations contained in the profile. AppConfig supports <code>feature
        /// flags</code> and <code>freeform</code> configurations. We recommend you create feature
        /// flag configurations to enable or disable new features and freeform configurations
        /// to distribute configurations to an application. When calling this API, enter one of
        /// the following values for <code>Type</code>:
        /// </para>
        ///  
        /// <para>
        ///  <code>AWS.AppConfig.FeatureFlags</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>AWS.Freeform</code> 
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Validators. 
        /// <para>
        /// A list of methods for validating the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<Validator> Validators
        {
            get { return this._validators; }
            set { this._validators = value; }
        }

        // Check to see if Validators property is set
        internal bool IsSetValidators()
        {
            return this._validators != null && this._validators.Count > 0; 
        }

    }
}