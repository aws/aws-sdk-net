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
 * Do not modify this file. This file is generated from the connectparticipant-2018-09-07.normal.json service model.
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
namespace Amazon.ConnectParticipant.Model
{
    /// <summary>
    /// A filtering option for where to start. For example, if you sent 100 messages, start
    /// with message 50.
    /// </summary>
    public partial class StartPosition
    {
        private string _absoluteTime;
        private string _id;
        private int? _mostRecent;

        /// <summary>
        /// Gets and sets the property AbsoluteTime. 
        /// <para>
        /// The time in ISO format where to start.
        /// </para>
        ///  
        /// <para>
        /// It's specified in ISO 8601 format: yyyy-MM-ddThh:mm:ss.SSSZ. For example, 2019-11-08T02:41:28.172Z.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string AbsoluteTime
        {
            get { return this._absoluteTime; }
            set { this._absoluteTime = value; }
        }

        // Check to see if AbsoluteTime property is set
        internal bool IsSetAbsoluteTime()
        {
            return this._absoluteTime != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the message or event where to start. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property MostRecent. 
        /// <para>
        /// The start position of the most recent message where you want to start. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? MostRecent
        {
            get { return this._mostRecent; }
            set { this._mostRecent = value; }
        }

        // Check to see if MostRecent property is set
        internal bool IsSetMostRecent()
        {
            return this._mostRecent.HasValue; 
        }

    }
}