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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Contains details about a distribution or image configuration failure for a single
    /// Region.
    /// </summary>
    public partial class RegionFailure
    {
        private string _errorMessage;
        private ImageConfigurationStep _imageConfigurationStep;
        private string _region;
        private RegionFailureStatus _status;
        private string _targetAccountId;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message for the failure in the Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=384000)]
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property ImageConfigurationStep. 
        /// <para>
        /// The image configuration step where the failure occurred. Image Builder sets this property
        /// when the failure happened during post-distribution configuration, such as launch template
        /// updates or virtual machine (VM) export. This property doesn't appear for failures
        /// that occurred while Image Builder copied the image to the Region.
        /// </para>
        /// </summary>
        public ImageConfigurationStep ImageConfigurationStep
        {
            get { return this._imageConfigurationStep; }
            set { this._imageConfigurationStep = value; }
        }

        // Check to see if ImageConfigurationStep property is set
        internal bool IsSetImageConfigurationStep()
        {
            return this._imageConfigurationStep != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Region where the failure occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The failure status for the Region. Indicates whether the process failed, was canceled,
        /// or timed out.
        /// </para>
        /// </summary>
        public RegionFailureStatus Status
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
        /// Gets and sets the property TargetAccountId. 
        /// <para>
        /// The account ID of the account that the image was distributed to in the Region.
        /// </para>
        /// </summary>
        public string TargetAccountId
        {
            get { return this._targetAccountId; }
            set { this._targetAccountId = value; }
        }

        // Check to see if TargetAccountId property is set
        internal bool IsSetTargetAccountId()
        {
            return this._targetAccountId != null;
        }

    }
}