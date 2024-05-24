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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Container for the parameters to the CopyImage operation.
    /// Copies the image within the same region or to a new region within the same AWS account.
    /// Note that any tags you added to the image will not be copied.
    /// </summary>
    public partial class CopyImageRequest : AmazonAppStreamRequest
    {
        private string _destinationImageDescription;
        private string _destinationImageName;
        private string _destinationRegion;
        private string _sourceImageName;

        /// <summary>
        /// Gets and sets the property DestinationImageDescription. 
        /// <para>
        /// The description that the image will have when it is copied to the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string DestinationImageDescription
        {
            get { return this._destinationImageDescription; }
            set { this._destinationImageDescription = value; }
        }

        // Check to see if DestinationImageDescription property is set
        internal bool IsSetDestinationImageDescription()
        {
            return this._destinationImageDescription != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationImageName. 
        /// <para>
        /// The name that the image will have when it is copied to the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DestinationImageName
        {
            get { return this._destinationImageName; }
            set { this._destinationImageName = value; }
        }

        // Check to see if DestinationImageName property is set
        internal bool IsSetDestinationImageName()
        {
            return this._destinationImageName != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationRegion. 
        /// <para>
        /// The destination region to which the image will be copied. This parameter is required,
        /// even if you are copying an image within the same region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string DestinationRegion
        {
            get { return this._destinationRegion; }
            set { this._destinationRegion = value; }
        }

        // Check to see if DestinationRegion property is set
        internal bool IsSetDestinationRegion()
        {
            return this._destinationRegion != null;
        }

        /// <summary>
        /// Gets and sets the property SourceImageName. 
        /// <para>
        /// The name of the image to copy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceImageName
        {
            get { return this._sourceImageName; }
            set { this._sourceImageName = value; }
        }

        // Check to see if SourceImageName property is set
        internal bool IsSetSourceImageName()
        {
            return this._sourceImageName != null;
        }

    }
}