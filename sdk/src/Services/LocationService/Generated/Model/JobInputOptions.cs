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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
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
namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Configuration for input data location and format.
    /// 
    ///  <note> 
    /// <para>
    /// Input files have a limitation of 10gb per file, and 1gb per Parquet row-group within
    /// the file.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class JobInputOptions
    {
        private JobInputFormat _format;
        private string _location;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// Input data format. Currently only <c>Parquet</c> is supported.
        /// </para>
        ///  <note> 
        /// <para>
        /// Input files have a limitation of 10gb per file, and 1gb per Parquet row-group within
        /// the file.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobInputFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// S3 ARN or URI where input files are stored.
        /// </para>
        ///  <note> 
        /// <para>
        /// The Amazon S3 bucket must be created in the same Amazon Web Services region where
        /// you plan to run your job.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=300)]
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

    }
}