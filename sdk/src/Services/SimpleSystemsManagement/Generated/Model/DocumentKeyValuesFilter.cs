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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// One or more filters. Use a filter to return a more specific list of documents.
    /// 
    ///  
    /// <para>
    /// For keys, you can specify one or more tags that have been applied to a document. 
    /// </para>
    ///  
    /// <para>
    /// You can also use Amazon Web Services-provided keys, some of which have specific allowed
    /// values. These keys and their associated values are as follows:
    /// </para>
    ///  <dl> <dt>DocumentType</dt> <dd> <ul> <li> 
    /// <para>
    ///  <c>ApplicationConfiguration</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ApplicationConfigurationSchema</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Automation</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ChangeCalendar</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Command</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Package</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Policy</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Session</c> 
    /// </para>
    ///  </li> </ul> </dd> <dt>Owner</dt> <dd> 
    /// <para>
    /// Note that only one <c>Owner</c> can be specified in a request. For example: <c>Key=Owner,Values=Self</c>.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>Amazon</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Private</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Public</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Self</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ThirdParty</c> 
    /// </para>
    ///  </li> </ul> </dd> <dt>PlatformTypes</dt> <dd> <ul> <li> 
    /// <para>
    ///  <c>Linux</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Windows</c> 
    /// </para>
    ///  </li> </ul> </dd> </dl> 
    /// <para>
    ///  <c>Name</c> is another Amazon Web Services-provided key. If you use <c>Name</c> as
    /// a key, you can use a name prefix to return a list of documents. For example, in the
    /// Amazon Web Services CLI, to return a list of all documents that begin with <c>Te</c>,
    /// run the following command:
    /// </para>
    ///  
    /// <para>
    ///  <c>aws ssm list-documents --filters Key=Name,Values=Te</c> 
    /// </para>
    ///  
    /// <para>
    /// You can also use the <c>TargetType</c> Amazon Web Services-provided key. For a list
    /// of valid resource type values that can be used with this key, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html">Amazon
    /// Web Services resource and property types reference</a> in the <i>CloudFormation User
    /// Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If you specify more than two keys, only documents that are identified by all the tags
    /// are returned in the results. If you specify more than two values for a key, documents
    /// that are identified by any of the values are returned in the results.
    /// </para>
    ///  
    /// <para>
    /// To specify a custom key-value pair, use the format <c>Key=tag:tagName,Values=valueName</c>.
    /// </para>
    ///  
    /// <para>
    /// For example, if you created a key called region and are using the Amazon Web Services
    /// CLI to call the <c>list-documents</c> command: 
    /// </para>
    ///  
    /// <para>
    ///  <c>aws ssm list-documents --filters Key=tag:region,Values=east,west Key=Owner,Values=Self</c>
    /// 
    /// </para>
    /// </summary>
    public partial class DocumentKeyValuesFilter
    {
        private string _key;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The name of the filter key.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The value for the filter key.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}