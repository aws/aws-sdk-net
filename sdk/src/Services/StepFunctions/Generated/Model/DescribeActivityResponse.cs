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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
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
namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// This is the response object from the DescribeActivity operation.
    /// </summary>
    public partial class DescribeActivityResponse : AmazonWebServiceResponse
    {
        private string _activityArn;
        private DateTime? _creationDate;
        private string _name;

        /// <summary>
        /// Gets and sets the property ActivityArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the activity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ActivityArn
        {
            get { return this._activityArn; }
            set { this._activityArn = value; }
        }

        // Check to see if ActivityArn property is set
        internal bool IsSetActivityArn()
        {
            return this._activityArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date the activity is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the activity.
        /// </para>
        ///  
        /// <para>
        /// A name must <i>not</i> contain:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// white space
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// brackets <c>&lt; &gt; { } [ ]</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// wildcard characters <c>? *</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// special characters <c>" # % \ ^ | ~ ` $ &amp; , ; : /</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// control characters (<c>U+0000-001F</c>, <c>U+007F-009F</c>)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To enable logging with CloudWatch Logs, the name should only contain 0-9, A-Z, a-z,
        /// - and _.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=80)]
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

    }
}