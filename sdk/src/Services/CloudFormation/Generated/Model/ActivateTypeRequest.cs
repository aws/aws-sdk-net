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
    /// Container for the parameters to the ActivateType operation.
    /// Activates a public third-party extension, making it available for use in stack templates.
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-public.html">Using
    /// public extensions</a> in the <i>CloudFormation User Guide</i>.
    /// 
    ///  
    /// <para>
    /// Once you have activated a public third-party extension in your account and Region,
    /// use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_SetTypeConfiguration.html">SetTypeConfiguration</a>
    /// to specify configuration properties for the extension. For more information, see <a
    /// href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-register.html#registry-set-configuration">Configuring
    /// extensions at the account level</a> in the <i>CloudFormation User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ActivateTypeRequest : AmazonCloudFormationRequest
    {
        private bool? _autoUpdate;
        private string _executionRoleArn;
        private LoggingConfig _loggingConfig;
        private long? _majorVersion;
        private string _publicTypeArn;
        private string _publisherId;
        private ThirdPartyType _type;
        private string _typeName;
        private string _typeNameAlias;
        private VersionBump _versionBump;

        /// <summary>
        /// Gets and sets the property AutoUpdate. 
        /// <para>
        /// Whether to automatically update the extension in this account and Region when a new
        /// <i>minor</i> version is published by the extension publisher. Major versions released
        /// by the publisher must be manually updated.
        /// </para>
        ///  
        /// <para>
        /// The default is <code>true</code>.
        /// </para>
        /// </summary>
        public bool AutoUpdate
        {
            get { return this._autoUpdate.GetValueOrDefault(); }
            set { this._autoUpdate = value; }
        }

        // Check to see if AutoUpdate property is set
        internal bool IsSetAutoUpdate()
        {
            return this._autoUpdate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The name of the IAM execution role to use to activate the extension.
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
        /// Gets and sets the property LoggingConfig. 
        /// <para>
        /// Contains logging configuration information for an extension.
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
        /// Gets and sets the property MajorVersion. 
        /// <para>
        /// The major version of this extension you want to activate, if multiple major versions
        /// are available. The default is the latest major version. CloudFormation uses the latest
        /// available <i>minor</i> version of the major version selected.
        /// </para>
        ///  
        /// <para>
        /// You can specify <code>MajorVersion</code> or <code>VersionBump</code>, but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100000)]
        public long MajorVersion
        {
            get { return this._majorVersion.GetValueOrDefault(); }
            set { this._majorVersion = value; }
        }

        // Check to see if MajorVersion property is set
        internal bool IsSetMajorVersion()
        {
            return this._majorVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PublicTypeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the public extension.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify <code>PublicTypeArn</code>, or <code>TypeName</code>,
        /// <code>Type</code>, and <code>PublisherId</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string PublicTypeArn
        {
            get { return this._publicTypeArn; }
            set { this._publicTypeArn = value; }
        }

        // Check to see if PublicTypeArn property is set
        internal bool IsSetPublicTypeArn()
        {
            return this._publicTypeArn != null;
        }

        /// <summary>
        /// Gets and sets the property PublisherId. 
        /// <para>
        /// The ID of the extension publisher.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify <code>PublicTypeArn</code>, or <code>TypeName</code>,
        /// <code>Type</code>, and <code>PublisherId</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=40)]
        public string PublisherId
        {
            get { return this._publisherId; }
            set { this._publisherId = value; }
        }

        // Check to see if PublisherId property is set
        internal bool IsSetPublisherId()
        {
            return this._publisherId != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The extension type.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify <code>PublicTypeArn</code>, or <code>TypeName</code>,
        /// <code>Type</code>, and <code>PublisherId</code>.
        /// </para>
        /// </summary>
        public ThirdPartyType Type
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
        /// The name of the extension.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify <code>PublicTypeArn</code>, or <code>TypeName</code>,
        /// <code>Type</code>, and <code>PublisherId</code>.
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
        /// Gets and sets the property TypeNameAlias. 
        /// <para>
        /// An alias to assign to the public extension, in this account and Region. If you specify
        /// an alias for the extension, CloudFormation treats the alias as the extension type
        /// name within this account and Region. You must use the alias to refer to the extension
        /// in your templates, API calls, and CloudFormation console.
        /// </para>
        ///  
        /// <para>
        /// An extension alias must be unique within a given account and Region. You can activate
        /// the same public resource multiple times in the same account and Region, using different
        /// type name aliases.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=204)]
        public string TypeNameAlias
        {
            get { return this._typeNameAlias; }
            set { this._typeNameAlias = value; }
        }

        // Check to see if TypeNameAlias property is set
        internal bool IsSetTypeNameAlias()
        {
            return this._typeNameAlias != null;
        }

        /// <summary>
        /// Gets and sets the property VersionBump. 
        /// <para>
        /// Manually updates a previously-activated type to a new major or minor version, if available.
        /// You can also use this parameter to update the value of <code>AutoUpdate</code>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>MAJOR</code>: CloudFormation updates the extension to the newest major version,
        /// if one is available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MINOR</code>: CloudFormation updates the extension to the newest minor version,
        /// if one is available.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public VersionBump VersionBump
        {
            get { return this._versionBump; }
            set { this._versionBump = value; }
        }

        // Check to see if VersionBump property is set
        internal bool IsSetVersionBump()
        {
            return this._versionBump != null;
        }

    }
}