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
    /// Container for the parameters to the GetParameters operation.
    /// Get information about one or more parameters by specifying multiple parameter names.
    /// 
    ///  <note> 
    /// <para>
    /// To get information about a single parameter, you can use the <a>GetParameter</a> operation
    /// instead.
    /// </para>
    ///  </note> 
    /// <para>
    /// Parameter names can't contain spaces. The service removes any spaces specified for
    /// the beginning or end of a parameter name. If the specified name for a parameter contains
    /// spaces between characters, the request fails with a <c>ValidationException</c> error.
    /// </para>
    /// </summary>
    public partial class GetParametersRequest : AmazonSimpleSystemsManagementRequest
    {
        private List<string> _names = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _withDecryption;

        /// <summary>
        /// Gets and sets the property Names. 
        /// <para>
        /// The names or Amazon Resource Names (ARNs) of the parameters that you want to query.
        /// For parameters shared with you from another account, you must use the full ARNs.
        /// </para>
        ///  
        /// <para>
        /// To query by parameter label, use <c>"Name": "name:label"</c>. To query by parameter
        /// version, use <c>"Name": "name:version"</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The results for <c>GetParameters</c> requests are listed in alphabetical order in
        /// query responses.
        /// </para>
        ///  </note> 
        /// <para>
        /// For information about shared parameters, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/parameter-store-shared-parameters.html">Working
        /// with shared parameters</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> Names
        {
            get { return this._names; }
            set { this._names = value; }
        }

        // Check to see if Names property is set
        internal bool IsSetNames()
        {
            return this._names != null && (this._names.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WithDecryption. 
        /// <para>
        /// Return decrypted secure string value. Return decrypted values for secure string parameters.
        /// This flag is ignored for <c>String</c> and <c>StringList</c> parameter types.
        /// </para>
        /// </summary>
        public bool? WithDecryption
        {
            get { return this._withDecryption; }
            set { this._withDecryption = value; }
        }

        // Check to see if WithDecryption property is set
        internal bool IsSetWithDecryption()
        {
            return this._withDecryption.HasValue; 
        }

    }
}