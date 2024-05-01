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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
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
namespace Amazon.Drs.Model
{
    /// <summary>
    /// An object containing information regarding the initiation of the last launch of a
    /// Source Server.
    /// </summary>
    public partial class LifeCycleLastLaunchInitiated
    {
        private string _apiCallDateTime;
        private string _jobid;
        private LastLaunchType _type;

        /// <summary>
        /// Gets and sets the property ApiCallDateTime. 
        /// <para>
        /// The date and time the last Source Server launch was initiated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=32)]
        public string ApiCallDateTime
        {
            get { return this._apiCallDateTime; }
            set { this._apiCallDateTime = value; }
        }

        // Check to see if ApiCallDateTime property is set
        internal bool IsSetApiCallDateTime()
        {
            return this._apiCallDateTime != null;
        }

        /// <summary>
        /// Gets and sets the property JobID. 
        /// <para>
        /// The ID of the Job that was used to last launch the Source Server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=24, Max=24)]
        public string JobID
        {
            get { return this._jobid; }
            set { this._jobid = value; }
        }

        // Check to see if JobID property is set
        internal bool IsSetJobID()
        {
            return this._jobid != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The Job type that was used to last launch the Source Server.
        /// </para>
        /// </summary>
        public LastLaunchType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}