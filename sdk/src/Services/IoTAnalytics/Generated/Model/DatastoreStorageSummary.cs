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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
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
namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// Contains information about your data store.
    /// </summary>
    public partial class DatastoreStorageSummary
    {
        private CustomerManagedDatastoreS3StorageSummary _customerManagedS3;
        private DatastoreIotSiteWiseMultiLayerStorageSummary _iotSiteWiseMultiLayerStorage;
        private ServiceManagedDatastoreS3StorageSummary _serviceManagedS3;

        /// <summary>
        /// Gets and sets the property CustomerManagedS3. 
        /// <para>
        /// Used to store data in an Amazon S3 bucket managed by IoT Analytics.
        /// </para>
        /// </summary>
        public CustomerManagedDatastoreS3StorageSummary CustomerManagedS3
        {
            get { return this._customerManagedS3; }
            set { this._customerManagedS3 = value; }
        }

        // Check to see if CustomerManagedS3 property is set
        internal bool IsSetCustomerManagedS3()
        {
            return this._customerManagedS3 != null;
        }

        /// <summary>
        /// Gets and sets the property IotSiteWiseMultiLayerStorage. 
        /// <para>
        ///  Used to store data used by IoT SiteWise in an Amazon S3 bucket that you manage. 
        /// </para>
        /// </summary>
        public DatastoreIotSiteWiseMultiLayerStorageSummary IotSiteWiseMultiLayerStorage
        {
            get { return this._iotSiteWiseMultiLayerStorage; }
            set { this._iotSiteWiseMultiLayerStorage = value; }
        }

        // Check to see if IotSiteWiseMultiLayerStorage property is set
        internal bool IsSetIotSiteWiseMultiLayerStorage()
        {
            return this._iotSiteWiseMultiLayerStorage != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceManagedS3. 
        /// <para>
        /// Used to store data in an Amazon S3 bucket managed by IoT Analytics.
        /// </para>
        /// </summary>
        public ServiceManagedDatastoreS3StorageSummary ServiceManagedS3
        {
            get { return this._serviceManagedS3; }
            set { this._serviceManagedS3 = value; }
        }

        // Check to see if ServiceManagedS3 property is set
        internal bool IsSetServiceManagedS3()
        {
            return this._serviceManagedS3 != null;
        }

    }
}