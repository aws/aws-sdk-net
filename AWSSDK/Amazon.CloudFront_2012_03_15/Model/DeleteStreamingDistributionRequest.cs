/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2010-11-01
 *
 */

using System.Xml.Serialization;

namespace Amazon.CloudFront_2012_03_15.Model
{
    /// <summary>
    /// The DeleteStreamingDistributionRequest contains the parameters used for the DeleteStreamingDistribution operation.
    /// <br />Required Parameters: Id
    /// <br />Required Parameters: ETag
    /// </summary>
    public class DeleteStreamingDistributionRequest : CloudFrontRequest
    {
        #region Id

        /// <summary>
        /// Gets and sets the Id property for the StreamingDistribution
        /// </summary>
        public override string Id
        {
            get
            {
                return this.distId;
            }
            set
            {
                this.distId = value;
            }
        }

        /// <summary>
        /// Sets the Id property of this request to the value passed in.
        /// </summary>
        /// <param name="id">The StreamingDistribution's id</param>
        /// <returns>The request with the Id property set</returns>
        public DeleteStreamingDistributionRequest WithId(string id)
        {
            this.distId = id;
            return this;
        }

        #endregion

        #region ETag

        /// <summary>
        /// Gets and sets the ETag property for the StreamingDistribution
        /// </summary>
        public override string ETag
        {
            get
            {
                return this.etagHeader;
            }
            set
            {
                this.etagHeader = value;
            }
        }

        /// <summary>
        /// Sets the ETag property of this request to the value passed in.
        /// </summary>
        /// <param name="etag">The StreamingDistribution's etag</param>
        /// <returns>The request with the ETag property set</returns>
        public DeleteStreamingDistributionRequest WithETag(string etag)
        {
            this.etagHeader = etag;
            return this;
        }

        #endregion
    }
}