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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
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
namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Contains the configuration information for the S3 location being used to hold label
    /// data.
    /// </summary>
    public partial class LabelsInputConfiguration
    {
        private string _labelGroupName;
        private LabelsS3InputConfiguration _s3InputConfiguration;

        /// <summary>
        /// Gets and sets the property LabelGroupName. 
        /// <para>
        ///  The name of the label group to be used for label data. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string LabelGroupName
        {
            get { return this._labelGroupName; }
            set { this._labelGroupName = value; }
        }

        // Check to see if LabelGroupName property is set
        internal bool IsSetLabelGroupName()
        {
            return this._labelGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property S3InputConfiguration. 
        /// <para>
        /// Contains location information for the S3 location being used for label data. 
        /// </para>
        /// </summary>
        public LabelsS3InputConfiguration S3InputConfiguration
        {
            get { return this._s3InputConfiguration; }
            set { this._s3InputConfiguration = value; }
        }

        // Check to see if S3InputConfiguration property is set
        internal bool IsSetS3InputConfiguration()
        {
            return this._s3InputConfiguration != null;
        }

    }
}