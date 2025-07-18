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
    /// Container for the parameters to the GetParameter operation.
    /// Get information about a single parameter by specifying the parameter name.
    /// 
    ///  
    /// <para>
    /// Parameter names can't contain spaces. The service removes any spaces specified for
    /// the beginning or end of a parameter name. If the specified name for a parameter contains
    /// spaces between characters, the request fails with a <c>ValidationException</c> error.
    /// </para>
    ///  <note> 
    /// <para>
    /// To get information about more than one parameter at a time, use the <a>GetParameters</a>
    /// operation.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetParameterRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _name;
        private bool? _withDecryption;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the parameter that you want to query. For
        /// parameters shared with you from another account, you must use the full ARN.
        /// </para>
        ///  
        /// <para>
        /// To query by parameter label, use <c>"Name": "name:label"</c>. To query by parameter
        /// version, use <c>"Name": "name:version"</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information about shared parameters, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/parameter-store-shared-parameters.html">Working
        /// with shared parameters</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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
        /// Gets and sets the property WithDecryption. 
        /// <para>
        /// Return decrypted values for secure string parameters. This flag is ignored for <c>String</c>
        /// and <c>StringList</c> parameter types.
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