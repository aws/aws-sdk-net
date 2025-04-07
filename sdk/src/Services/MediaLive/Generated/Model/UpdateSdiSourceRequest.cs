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
    /// Container for the parameters to the UpdateSdiSource operation.
    /// Change some of the settings in an SdiSource.
    /// </summary>
    public partial class UpdateSdiSourceRequest : AmazonMediaLiveRequest
    {
        private SdiSourceMode _mode;
        private string _name;
        private string _sdiSourceId;
        private SdiSourceType _type;

        /// <summary>
        /// Gets and sets the property Mode. Include this parameter only if you want to change
        /// the name of the SdiSource. Specify a name that is unique in the AWS account. We recommend
        /// you assign a name that describes the source, for example curling-cameraA. Names are
        /// case-sensitive.
        /// </summary>
        public SdiSourceMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property Name. Include this parameter only if you want to change
        /// the name of the SdiSource. Specify a name that is unique in the AWS account. We recommend
        /// you assign a name that describes the source, for example curling-cameraA. Names are
        /// case-sensitive.
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property SdiSourceId. The ID of the SdiSource
        /// </summary>
        [AWSProperty(Required=true)]
        public string SdiSourceId
        {
            get { return this._sdiSourceId; }
            set { this._sdiSourceId = value; }
        }

        // Check to see if SdiSourceId property is set
        internal bool IsSetSdiSourceId()
        {
            return this._sdiSourceId != null;
        }

        /// <summary>
        /// Gets and sets the property Type. Include this parameter only if you want to change
        /// the mode. Specify the type of the SDI source: SINGLE: The source is a single-link
        /// source. QUAD: The source is one part of a quad-link source.
        /// </summary>
        public SdiSourceType Type
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