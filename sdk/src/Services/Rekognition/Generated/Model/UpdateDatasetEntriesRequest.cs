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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDatasetEntries operation.
    /// <note> 
    /// <para>
    /// This operation applies only to Amazon Rekognition Custom Labels.
    /// </para>
    ///  </note> 
    /// <para>
    /// Adds or updates one or more entries (images) in a dataset. An entry is a JSON Line
    /// which contains the information for a single image, including the image location, assigned
    /// labels, and object location bounding boxes. For more information, see Image-Level
    /// labels in manifest files and Object localization in manifest files in the <i>Amazon
    /// Rekognition Custom Labels Developer Guide</i>. 
    /// </para>
    ///  
    /// <para>
    /// If the <c>source-ref</c> field in the JSON line references an existing image, the
    /// existing image in the dataset is updated. If <c>source-ref</c> field doesn't reference
    /// an existing image, the image is added as a new image to the dataset. 
    /// </para>
    ///  
    /// <para>
    /// You specify the changes that you want to make in the <c>Changes</c> input parameter.
    /// There isn't a limit to the number JSON Lines that you can change, but the size of
    /// <c>Changes</c> must be less than 5MB.
    /// </para>
    ///  
    /// <para>
    ///  <c>UpdateDatasetEntries</c> returns immediatly, but the dataset update might take
    /// a while to complete. Use <a>DescribeDataset</a> to check the current status. The dataset
    /// updated successfully if the value of <c>Status</c> is <c>UPDATE_COMPLETE</c>. 
    /// </para>
    ///  
    /// <para>
    /// To check if any non-terminal errors occured, call <a>ListDatasetEntries</a> and check
    /// for the presence of <c>errors</c> lists in the JSON Lines.
    /// </para>
    ///  
    /// <para>
    /// Dataset update fails if a terminal error occurs (<c>Status</c> = <c>UPDATE_FAILED</c>).
    /// Currently, you can't access the terminal error information from the Amazon Rekognition
    /// Custom Labels SDK. 
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <c>rekognition:UpdateDatasetEntries</c>
    /// action.
    /// </para>
    /// </summary>
    public partial class UpdateDatasetEntriesRequest : AmazonRekognitionRequest
    {
        private DatasetChanges _changes;
        private string _datasetArn;

        /// <summary>
        /// Gets and sets the property Changes. 
        /// <para>
        ///  The changes that you want to make to the dataset. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DatasetChanges Changes
        {
            get { return this._changes; }
            set { this._changes = value; }
        }

        // Check to see if Changes property is set
        internal bool IsSetChanges()
        {
            return this._changes != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the dataset that you want to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string DatasetArn
        {
            get { return this._datasetArn; }
            set { this._datasetArn = value; }
        }

        // Check to see if DatasetArn property is set
        internal bool IsSetDatasetArn()
        {
            return this._datasetArn != null;
        }

    }
}