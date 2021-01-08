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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECR.Model
{
    /// <summary>
    /// This is the response object from the DescribeImageScanFindings operation.
    /// </summary>
    public partial class DescribeImageScanFindingsResponse : AmazonWebServiceResponse
    {
        private ImageIdentifier _imageId;
        private ImageScanFindings _imageScanFindings;
        private ImageScanStatus _imageScanStatus;
        private string _nextToken;
        private string _registryId;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property ImageId.
        /// </summary>
        public ImageIdentifier ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }

        /// <summary>
        /// Gets and sets the property ImageScanFindings. 
        /// <para>
        /// The information contained in the image scan findings.
        /// </para>
        /// </summary>
        public ImageScanFindings ImageScanFindings
        {
            get { return this._imageScanFindings; }
            set { this._imageScanFindings = value; }
        }

        // Check to see if ImageScanFindings property is set
        internal bool IsSetImageScanFindings()
        {
            return this._imageScanFindings != null;
        }

        /// <summary>
        /// Gets and sets the property ImageScanStatus. 
        /// <para>
        /// The current state of the scan.
        /// </para>
        /// </summary>
        public ImageScanStatus ImageScanStatus
        {
            get { return this._imageScanStatus; }
            set { this._imageScanStatus = value; }
        }

        // Check to see if ImageScanStatus property is set
        internal bool IsSetImageScanStatus()
        {
            return this._imageScanStatus != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> value to include in a future <code>DescribeImageScanFindings</code>
        /// request. When the results of a <code>DescribeImageScanFindings</code> request exceed
        /// <code>maxResults</code>, this value can be used to retrieve the next page of results.
        /// This value is null when there are no more results to return.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The registry ID associated with the request.
        /// </para>
        /// </summary>
        public string RegistryId
        {
            get { return this._registryId; }
            set { this._registryId = value; }
        }

        // Check to see if RegistryId property is set
        internal bool IsSetRegistryId()
        {
            return this._registryId != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The repository name associated with the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=256)]
        public string RepositoryName
        {
            get { return this._repositoryName; }
            set { this._repositoryName = value; }
        }

        // Check to see if RepositoryName property is set
        internal bool IsSetRepositoryName()
        {
            return this._repositoryName != null;
        }

    }
}