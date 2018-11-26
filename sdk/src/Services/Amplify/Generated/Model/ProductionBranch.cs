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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Amplify.Model
{
    /// <summary>
    /// Structure with Production Branch information.
    /// </summary>
    public partial class ProductionBranch
    {
        private string _branchName;
        private DateTime? _lastDeployTime;
        private string _status;
        private string _thumbnailUrl;

        /// <summary>
        /// Gets and sets the property BranchName. 
        /// <para>
        ///  Branch Name for Production Branch. 
        /// </para>
        /// </summary>
        public string BranchName
        {
            get { return this._branchName; }
            set { this._branchName = value; }
        }

        // Check to see if BranchName property is set
        internal bool IsSetBranchName()
        {
            return this._branchName != null;
        }

        /// <summary>
        /// Gets and sets the property LastDeployTime. 
        /// <para>
        ///  Last Deploy Time of Production Branch. 
        /// </para>
        /// </summary>
        public DateTime LastDeployTime
        {
            get { return this._lastDeployTime.GetValueOrDefault(); }
            set { this._lastDeployTime = value; }
        }

        // Check to see if LastDeployTime property is set
        internal bool IsSetLastDeployTime()
        {
            return this._lastDeployTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  Status of Production Branch. 
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property ThumbnailUrl. 
        /// <para>
        ///  Thumbnail Url for Production Branch. 
        /// </para>
        /// </summary>
        public string ThumbnailUrl
        {
            get { return this._thumbnailUrl; }
            set { this._thumbnailUrl = value; }
        }

        // Check to see if ThumbnailUrl property is set
        internal bool IsSetThumbnailUrl()
        {
            return this._thumbnailUrl != null;
        }

    }
}