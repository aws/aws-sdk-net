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
 * Do not modify this file. This file is generated from the resource-groups-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResourceGroups.Model
{
    /// <summary>
    /// Container for the parameters to the Untag operation.
    /// Deletes tags from a specified resource group.
    /// 
    ///  
    /// <para>
    ///  <b>Minimum permissions</b> 
    /// </para>
    ///  
    /// <para>
    /// To run this command, you must have the following permissions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>resource-groups:Untag</code> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class UntagRequest : AmazonResourceGroupsRequest
    {
        private string _arn;
        private List<string> _keys = new List<string>();

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the resource group from which to remove tags. The command removed both
        /// the specified keys and any values associated with those keys.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=1600)]
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
        /// Gets and sets the property Keys. 
        /// <para>
        /// The keys of the tags to be removed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Keys
        {
            get { return this._keys; }
            set { this._keys = value; }
        }

        // Check to see if Keys property is set
        internal bool IsSetKeys()
        {
            return this._keys != null && this._keys.Count > 0; 
        }

    }
}