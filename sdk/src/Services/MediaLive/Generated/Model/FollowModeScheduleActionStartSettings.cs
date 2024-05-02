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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Settings to specify if an action follows another.
    /// </summary>
    public partial class FollowModeScheduleActionStartSettings
    {
        private FollowPoint _followPoint;
        private string _referenceActionName;

        /// <summary>
        /// Gets and sets the property FollowPoint. Identifies whether this action starts relative
        /// to the start or relative to the end of the reference action.
        /// </summary>
        [AWSProperty(Required=true)]
        public FollowPoint FollowPoint
        {
            get { return this._followPoint; }
            set { this._followPoint = value; }
        }

        // Check to see if FollowPoint property is set
        internal bool IsSetFollowPoint()
        {
            return this._followPoint != null;
        }

        /// <summary>
        /// Gets and sets the property ReferenceActionName. The action name of another action
        /// that this one refers to.
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReferenceActionName
        {
            get { return this._referenceActionName; }
            set { this._referenceActionName = value; }
        }

        // Check to see if ReferenceActionName property is set
        internal bool IsSetReferenceActionName()
        {
            return this._referenceActionName != null;
        }

    }
}