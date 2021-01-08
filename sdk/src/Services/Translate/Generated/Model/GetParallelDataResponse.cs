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
 * Do not modify this file. This file is generated from the translate-2017-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Translate.Model
{
    /// <summary>
    /// This is the response object from the GetParallelData operation.
    /// </summary>
    public partial class GetParallelDataResponse : AmazonWebServiceResponse
    {
        private ParallelDataDataLocation _auxiliaryDataLocation;
        private ParallelDataDataLocation _dataLocation;
        private ParallelDataDataLocation _latestUpdateAttemptAuxiliaryDataLocation;
        private ParallelDataProperties _parallelDataProperties;

        /// <summary>
        /// Gets and sets the property AuxiliaryDataLocation. 
        /// <para>
        /// The Amazon S3 location of a file that provides any errors or warnings that were produced
        /// by your input file. This file was created when Amazon Translate attempted to create
        /// a parallel data resource. The location is returned as a presigned URL to that has
        /// a 30 minute expiration.
        /// </para>
        /// </summary>
        public ParallelDataDataLocation AuxiliaryDataLocation
        {
            get { return this._auxiliaryDataLocation; }
            set { this._auxiliaryDataLocation = value; }
        }

        // Check to see if AuxiliaryDataLocation property is set
        internal bool IsSetAuxiliaryDataLocation()
        {
            return this._auxiliaryDataLocation != null;
        }

        /// <summary>
        /// Gets and sets the property DataLocation. 
        /// <para>
        /// The location of the most recent parallel data input file that was successfully imported
        /// into Amazon Translate. The location is returned as a presigned URL that has a 30 minute
        /// expiration.
        /// </para>
        /// </summary>
        public ParallelDataDataLocation DataLocation
        {
            get { return this._dataLocation; }
            set { this._dataLocation = value; }
        }

        // Check to see if DataLocation property is set
        internal bool IsSetDataLocation()
        {
            return this._dataLocation != null;
        }

        /// <summary>
        /// Gets and sets the property LatestUpdateAttemptAuxiliaryDataLocation. 
        /// <para>
        /// The Amazon S3 location of a file that provides any errors or warnings that were produced
        /// by your input file. This file was created when Amazon Translate attempted to update
        /// a parallel data resource. The location is returned as a presigned URL to that has
        /// a 30 minute expiration.
        /// </para>
        /// </summary>
        public ParallelDataDataLocation LatestUpdateAttemptAuxiliaryDataLocation
        {
            get { return this._latestUpdateAttemptAuxiliaryDataLocation; }
            set { this._latestUpdateAttemptAuxiliaryDataLocation = value; }
        }

        // Check to see if LatestUpdateAttemptAuxiliaryDataLocation property is set
        internal bool IsSetLatestUpdateAttemptAuxiliaryDataLocation()
        {
            return this._latestUpdateAttemptAuxiliaryDataLocation != null;
        }

        /// <summary>
        /// Gets and sets the property ParallelDataProperties. 
        /// <para>
        /// The properties of the parallel data resource that is being retrieved.
        /// </para>
        /// </summary>
        public ParallelDataProperties ParallelDataProperties
        {
            get { return this._parallelDataProperties; }
            set { this._parallelDataProperties = value; }
        }

        // Check to see if ParallelDataProperties property is set
        internal bool IsSetParallelDataProperties()
        {
            return this._parallelDataProperties != null;
        }

    }
}