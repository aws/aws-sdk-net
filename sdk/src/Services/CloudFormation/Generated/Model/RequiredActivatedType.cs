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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// For extensions that are modules, a public third-party extension that must be activated
    /// in your account in order for the module itself to be activated.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/module-versioning.html#requirements-for-modules">Requirements
    /// for activating third-party public modules</a> in the <i>CloudFormation User Guide</i>.
    /// </para>
    /// </summary>
    public partial class RequiredActivatedType
    {
        private string _originalTypeName;
        private string _publisherId;
        private List<int> _supportedMajorVersions = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private string _typeNameAlias;

        /// <summary>
        /// Gets and sets the property OriginalTypeName. 
        /// <para>
        /// The type name of the public extension.
        /// </para>
        ///  
        /// <para>
        /// If you specified a <c>TypeNameAlias</c> when enabling the extension in this account
        /// and Region, CloudFormation treats that alias as the extension's type name within the
        /// account and Region, not the type name of the public extension. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-public.html#registry-public-enable-alias">Use
        /// aliases to refer to extensions</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=204)]
        public string OriginalTypeName
        {
            get { return this._originalTypeName; }
            set { this._originalTypeName = value; }
        }

        // Check to see if OriginalTypeName property is set
        internal bool IsSetOriginalTypeName()
        {
            return this._originalTypeName != null;
        }

        /// <summary>
        /// Gets and sets the property PublisherId. 
        /// <para>
        /// The publisher ID of the extension publisher.
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
        /// Gets and sets the property SupportedMajorVersions. 
        /// <para>
        /// A list of the major versions of the extension type that the macro supports.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> SupportedMajorVersions
        {
            get { return this._supportedMajorVersions; }
            set { this._supportedMajorVersions = value; }
        }

        // Check to see if SupportedMajorVersions property is set
        internal bool IsSetSupportedMajorVersions()
        {
            return this._supportedMajorVersions != null && (this._supportedMajorVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TypeNameAlias. 
        /// <para>
        /// An alias assigned to the public extension, in this account and Region. If you specify
        /// an alias for the extension, CloudFormation treats the alias as the extension type
        /// name within this account and Region. You must use the alias to refer to the extension
        /// in your templates, API calls, and CloudFormation console.
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

    }
}