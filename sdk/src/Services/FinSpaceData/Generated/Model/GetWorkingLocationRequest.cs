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
 * Do not modify this file. This file is generated from the finspace-data-2020-07-13.normal.json service model.
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
namespace Amazon.FinSpaceData.Model
{
    /// <summary>
    /// Container for the parameters to the GetWorkingLocation operation.
    /// A temporary Amazon S3 location, where you can copy your files from a source location
    /// to stage or use as a scratch space in FinSpace notebook.
    /// </summary>
    public partial class GetWorkingLocationRequest : AmazonFinSpaceDataRequest
    {
        private LocationType _locationType;

        /// <summary>
        /// Gets and sets the property LocationType. 
        /// <para>
        /// Specify the type of the working location.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SAGEMAKER</c> – Use the Amazon S3 location as a temporary location to store data
        /// content when working with FinSpace Notebooks that run on SageMaker studio.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INGESTION</c> – Use the Amazon S3 location as a staging location to copy your
        /// data content and then use the location with the Changeset creation operation.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public LocationType LocationType
        {
            get { return this._locationType; }
            set { this._locationType = value; }
        }

        // Check to see if LocationType property is set
        internal bool IsSetLocationType()
        {
            return this._locationType != null;
        }

    }
}