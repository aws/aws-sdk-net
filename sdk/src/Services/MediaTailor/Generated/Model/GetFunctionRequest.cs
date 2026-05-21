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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
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
namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// Container for the parameters to the GetFunction operation.
    /// Retrieves the configuration and metadata for a function. For more information about
    /// functions, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/monetization-functions.html">Working
    /// with functions</a> in the <i>MediaTailor User Guide</i>.
    /// </summary>
    public partial class GetFunctionRequest : AmazonMediaTailorRequest
    {
        private string _functionId;

        /// <summary>
        /// Gets and sets the property FunctionId. 
        /// <para>
        /// The identifier of the function.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FunctionId
        {
            get { return this._functionId; }
            set { this._functionId = value; }
        }

        // Check to see if FunctionId property is set
        internal bool IsSetFunctionId()
        {
            return this._functionId != null;
        }

    }
}