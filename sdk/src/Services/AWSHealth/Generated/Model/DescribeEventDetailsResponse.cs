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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// This is the response object from the DescribeEventDetails operation.
    /// </summary>
    public partial class DescribeEventDetailsResponse : AmazonWebServiceResponse
    {
        private List<EventDetailsErrorItem> _failedSet = new List<EventDetailsErrorItem>();
        private List<EventDetails> _successfulSet = new List<EventDetails>();

        /// <summary>
        /// Gets and sets the property FailedSet. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public List<EventDetailsErrorItem> FailedSet
        {
            get { return this._failedSet; }
            set { this._failedSet = value; }
        }

        // Check to see if FailedSet property is set
        internal bool IsSetFailedSet()
        {
            return this._failedSet != null && this._failedSet.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SuccessfulSet. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public List<EventDetails> SuccessfulSet
        {
            get { return this._successfulSet; }
            set { this._successfulSet = value; }
        }

        // Check to see if SuccessfulSet property is set
        internal bool IsSetSuccessfulSet()
        {
            return this._successfulSet != null && this._successfulSet.Count > 0; 
        }

    }
}