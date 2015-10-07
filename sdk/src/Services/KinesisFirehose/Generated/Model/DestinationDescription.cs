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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Describes the destination for a delivery stream.
    /// </summary>
    public partial class DestinationDescription
    {
        private string _destinationId;
        private RedshiftDestinationDescription _redshiftDestinationDescription;
        private S3DestinationDescription _s3DestinationDescription;

        /// <summary>
        /// Gets and sets the property DestinationId. 
        /// <para>
        /// The ID of the destination.
        /// </para>
        /// </summary>
        public string DestinationId
        {
            get { return this._destinationId; }
            set { this._destinationId = value; }
        }

        // Check to see if DestinationId property is set
        internal bool IsSetDestinationId()
        {
            return this._destinationId != null;
        }

        /// <summary>
        /// Gets and sets the property RedshiftDestinationDescription. 
        /// <para>
        /// The destination in Amazon Redshift.
        /// </para>
        /// </summary>
        public RedshiftDestinationDescription RedshiftDestinationDescription
        {
            get { return this._redshiftDestinationDescription; }
            set { this._redshiftDestinationDescription = value; }
        }

        // Check to see if RedshiftDestinationDescription property is set
        internal bool IsSetRedshiftDestinationDescription()
        {
            return this._redshiftDestinationDescription != null;
        }

        /// <summary>
        /// Gets and sets the property S3DestinationDescription. 
        /// <para>
        /// The Amazon S3 destination.
        /// </para>
        /// </summary>
        public S3DestinationDescription S3DestinationDescription
        {
            get { return this._s3DestinationDescription; }
            set { this._s3DestinationDescription = value; }
        }

        // Check to see if S3DestinationDescription property is set
        internal bool IsSetS3DestinationDescription()
        {
            return this._s3DestinationDescription != null;
        }

    }
}