/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ReleaseHostsResponse : AmazonWebServiceResponse
    {
        private List<string> _successful = new List<string>();
        private List<UnsuccessfulItem> _unsuccessful = new List<UnsuccessfulItem>();

        /// <summary>
        /// Gets and sets the property Successful. 
        /// <para>
        /// The IDs of the Dedicated hosts that were successfully released.
        /// </para>
        /// </summary>
        public List<string> Successful
        {
            get { return this._successful; }
            set { this._successful = value; }
        }

        // Check to see if Successful property is set
        internal bool IsSetSuccessful()
        {
            return this._successful != null && this._successful.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Unsuccessful. 
        /// <para>
        /// The IDs of the Dedicated hosts that could not be released, including an error message.
        /// </para>
        /// </summary>
        public List<UnsuccessfulItem> Unsuccessful
        {
            get { return this._unsuccessful; }
            set { this._unsuccessful = value; }
        }

        // Check to see if Unsuccessful property is set
        internal bool IsSetUnsuccessful()
        {
            return this._unsuccessful != null && this._unsuccessful.Count > 0; 
        }

    }
}