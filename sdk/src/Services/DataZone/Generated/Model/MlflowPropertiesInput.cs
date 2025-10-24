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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The MLflow properties of a connection.
    /// </summary>
    public partial class MlflowPropertiesInput
    {
        private string _trackingServerArn;
        private string _trackingServerName;

        /// <summary>
        /// Gets and sets the property TrackingServerArn. 
        /// <para>
        /// The tracking server ARN as part of the MLflow properties of a connection.
        /// </para>
        /// </summary>
        public string TrackingServerArn
        {
            get { return this._trackingServerArn; }
            set { this._trackingServerArn = value; }
        }

        // Check to see if TrackingServerArn property is set
        internal bool IsSetTrackingServerArn()
        {
            return this._trackingServerArn != null;
        }

        /// <summary>
        /// Gets and sets the property TrackingServerName. 
        /// <para>
        /// The name of the tracking server as part of the MLflow properties of a connection.
        /// </para>
        /// </summary>
        public string TrackingServerName
        {
            get { return this._trackingServerName; }
            set { this._trackingServerName = value; }
        }

        // Check to see if TrackingServerName property is set
        internal bool IsSetTrackingServerName()
        {
            return this._trackingServerName != null;
        }

    }
}