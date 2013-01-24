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
    /// The GetDistributionInfoRequest contains the parameters used for the GetDistributionInfo operation.
    /// <br />Required Parameter: Id
    /// </summary>
    public class GetDistributionInfoRequest : CloudFrontRequest
    {
        #region Id

        /// <summary>
        /// Gets and sets the Id property for the Distribution
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
        /// <param name="id">The distribution's id</param>
        /// <returns>The request with the Id property set</returns>
        public GetDistributionInfoRequest WithId(string id)
        {
            this.distId = id;
            return this;
        }

        #endregion
    }
}