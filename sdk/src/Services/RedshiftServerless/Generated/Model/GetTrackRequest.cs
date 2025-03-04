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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
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
namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// Container for the parameters to the GetTrack operation.
    /// Get the Redshift Serverless version for a specified track.
    /// </summary>
    public partial class GetTrackRequest : AmazonRedshiftServerlessRequest
    {
        private string _trackName;

        /// <summary>
        /// Gets and sets the property TrackName. 
        /// <para>
        /// The name of the track of which its version is fetched.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string TrackName
        {
            get { return this._trackName; }
            set { this._trackName = value; }
        }

        // Check to see if TrackName property is set
        internal bool IsSetTrackName()
        {
            return this._trackName != null;
        }

    }
}