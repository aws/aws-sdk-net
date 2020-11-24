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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// This is the response object from the DescribeType operation.
    /// </summary>
    public partial class DescribeTypeResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _defaultVersionId;
        private DeprecatedStatus _deprecatedStatus;
        private string _description;
        private string _documentationUrl;
        private string _executionRoleArn;
        private bool? _isDefaultVersion;
        private DateTime? _lastUpdated;
        private LoggingConfig _loggingConfig;
        private ProvisioningType _provisioningType;
        private string _schema;
        private string _sourceUrl;
        private DateTime? _timeCreated;
        private RegistryType _type;
        private string _typeName;
        private Visibility _visibility;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the type.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultVersionId. 
        /// <para>
        /// The ID of the default version of the type. The default version is used when the type
        /// version is not specified.
        /// </para>
        ///  
        /// <para>
        /// To set the default version of a type, use <code> <a>SetTypeDefaultVersion</a> </code>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string DefaultVersionId
        {
            get { return this._defaultVersionId; }
            set { this._defaultVersionId = value; }
        }

        // Check to see if DefaultVersionId property is set
        internal bool IsSetDefaultVersionId()
        {
            return this._defaultVersionId != null;
        }

        /// <summary>
        /// Gets and sets the property DeprecatedStatus. 
        /// <para>
        /// The deprecation status of the type.
        /// </para>
        ///  
        /// <para>
        /// Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>LIVE</code>: The type is registered and can be used in CloudFormation operations,
        /// dependent on its provisioning behavior and visibility scope.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DEPRECATED</code>: The type has been deregistered and can no longer be used
        /// in CloudFormation operations. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DeprecatedStatus DeprecatedStatus
        {
            get { return this._deprecatedStatus; }
            set { this._deprecatedStatus = value; }
        }

        // Check to see if DeprecatedStatus property is set
        internal bool IsSetDeprecatedStatus()
        {
            return this._deprecatedStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the registered type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property DocumentationUrl. 
        /// <para>
        /// The URL of a page providing detailed documentation for this type.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string DocumentationUrl
        {
            get { return this._documentationUrl; }
            set { this._documentationUrl = value; }
        }

        // Check to see if DocumentationUrl property is set
        internal bool IsSetDocumentationUrl()
        {
            return this._documentationUrl != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM execution role used to register the type.
        /// If your resource type calls AWS APIs in any of its handlers, you must create an <i>
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles.html">IAM execution
        /// role</a> </i> that includes the necessary permissions to call those AWS APIs, and
        /// provision that execution role in your account. CloudFormation then assumes that execution
        /// role to provide your resource type with the appropriate credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property IsDefaultVersion. 
        /// <para>
        /// Whether the specified type version is set as the default version.
        /// </para>
        /// </summary>
        public bool IsDefaultVersion
        {
            get { return this._isDefaultVersion.GetValueOrDefault(); }
            set { this._isDefaultVersion = value; }
        }

        // Check to see if IsDefaultVersion property is set
        internal bool IsSetIsDefaultVersion()
        {
            return this._isDefaultVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// When the specified type version was registered.
        /// </para>
        /// </summary>
        public DateTime LastUpdated
        {
            get { return this._lastUpdated.GetValueOrDefault(); }
            set { this._lastUpdated = value; }
        }

        // Check to see if LastUpdated property is set
        internal bool IsSetLastUpdated()
        {
            return this._lastUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LoggingConfig. 
        /// <para>
        /// Contains logging configuration information for a type.
        /// </para>
        /// </summary>
        public LoggingConfig LoggingConfig
        {
            get { return this._loggingConfig; }
            set { this._loggingConfig = value; }
        }

        // Check to see if LoggingConfig property is set
        internal bool IsSetLoggingConfig()
        {
            return this._loggingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisioningType. 
        /// <para>
        /// The provisioning behavior of the type. AWS CloudFormation determines the provisioning
        /// type during registration, based on the types of handlers in the schema handler package
        /// submitted.
        /// </para>
        ///  
        /// <para>
        /// Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>FULLY_MUTABLE</code>: The type includes an update handler to process updates
        /// to the type during stack update operations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IMMUTABLE</code>: The type does not include an update handler, so the type
        /// cannot be updated and must instead be replaced during stack update operations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NON_PROVISIONABLE</code>: The type does not include all of the following handlers,
        /// and therefore cannot actually be provisioned.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// create
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// read
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// delete
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        public ProvisioningType ProvisioningType
        {
            get { return this._provisioningType; }
            set { this._provisioningType = value; }
        }

        // Check to see if ProvisioningType property is set
        internal bool IsSetProvisioningType()
        {
            return this._provisioningType != null;
        }

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// The schema that defines the type.
        /// </para>
        ///  
        /// <para>
        /// For more information on type schemas, see <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/resource-type-schema.html">Resource
        /// Provider Schema</a> in the <i>CloudFormation CLI User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16777216)]
        public string Schema
        {
            get { return this._schema; }
            set { this._schema = value; }
        }

        // Check to see if Schema property is set
        internal bool IsSetSchema()
        {
            return this._schema != null;
        }

        /// <summary>
        /// Gets and sets the property SourceUrl. 
        /// <para>
        /// The URL of the source code for the type.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string SourceUrl
        {
            get { return this._sourceUrl; }
            set { this._sourceUrl = value; }
        }

        // Check to see if SourceUrl property is set
        internal bool IsSetSourceUrl()
        {
            return this._sourceUrl != null;
        }

        /// <summary>
        /// Gets and sets the property TimeCreated. 
        /// <para>
        /// When the specified type version was registered.
        /// </para>
        /// </summary>
        public DateTime TimeCreated
        {
            get { return this._timeCreated.GetValueOrDefault(); }
            set { this._timeCreated = value; }
        }

        // Check to see if TimeCreated property is set
        internal bool IsSetTimeCreated()
        {
            return this._timeCreated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The kind of type. 
        /// </para>
        ///  
        /// <para>
        /// Currently the only valid value is <code>RESOURCE</code>.
        /// </para>
        /// </summary>
        public RegistryType Type
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
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The name of the registered type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=204)]
        public string TypeName
        {
            get { return this._typeName; }
            set { this._typeName = value; }
        }

        // Check to see if TypeName property is set
        internal bool IsSetTypeName()
        {
            return this._typeName != null;
        }

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// The scope at which the type is visible and usable in CloudFormation operations.
        /// </para>
        ///  
        /// <para>
        /// Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>PRIVATE</code>: The type is only visible and usable within the account in which
        /// it is registered. Currently, AWS CloudFormation marks any types you register as <code>PRIVATE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PUBLIC</code>: The type is publically visible and usable within any Amazon
        /// account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Visibility Visibility
        {
            get { return this._visibility; }
            set { this._visibility = value; }
        }

        // Check to see if Visibility property is set
        internal bool IsSetVisibility()
        {
            return this._visibility != null;
        }

    }
}