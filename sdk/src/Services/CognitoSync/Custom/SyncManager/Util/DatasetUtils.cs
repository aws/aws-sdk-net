//
// Copyright 2014-2015 Amazon.com, 
// Inc. or its affiliates. All Rights Reserved.
// 
// SPDX-License-Identifier: Apache-2.0
//

using System;
using System.Text.RegularExpressions;

using Amazon.CognitoIdentity;
using Amazon.Runtime.Internal.Util;
using System.Text;

namespace Amazon.CognitoSync.SyncManager.Internal
{
    /// <summary>
    /// A Utility class for all the dataset operations
    /// </summary>
    public static class DatasetUtils
    {
        /// <summary>
        /// Valid dataset name pattern
        /// </summary>
        public static readonly string DATASET_NAME_PATTERN = @"^[a-zA-Z0-9_.:-]{1,128}$";

        /// <summary>
        /// Unknown identity id when the identity id is null
        /// </summary>
        public static readonly string UNKNOWN_IDENTITY_ID = "unknown";

        /// <summary>
        /// Validates the dataset name.
        /// </summary>
        /// <returns>The dataset name.</returns>
        /// <param name="datasetName">Dataset name.</param>
        public static string ValidateDatasetName(string datasetName)
        {
            if (!Regex.IsMatch(datasetName, DATASET_NAME_PATTERN))
            {
                throw new ArgumentException("Invalid dataset name");
            }
            return datasetName;
        }

        /// <summary>
        /// Validates the record key. It must be non empty and its length must be no
        /// greater than 128. Otherwise {@link IllegalArgumentException} will be
        /// thrown.
        /// </summary>
        /// <returns>The record key.</returns>
        /// <param name="key">Key.</param>
        public static string ValidateRecordKey(string key)
        {
            if (string.IsNullOrEmpty(key) || Encoding.UTF8.GetByteCount(key) > 128)
            {
                throw new ArgumentException("Invalid record key");
            }
            return key;
        }

        /// <summary>
        /// A helper function to compute record size which equals the sum of the
        /// UTF-8 string length of record key and value. 0 if record is null.
        /// </summary>
        /// <returns>The record size.</returns>
        /// <param name="record">Record.</param>
        public static long ComputeRecordSize(Record record)
        {
            if (record == null)
            {
                return 0;
            }
            return Encoding.UTF8.GetByteCount(record.Key)
                + Encoding.UTF8.GetByteCount(record.Value);
        }

        /// <summary>
        /// A helper function to get the identity id of the dataset from credentials
        /// provider. If the identity id is null, UNKNOWN_IDENTITY_ID will be
        /// returned.
        /// </summary>
        /// <param name="credentials">The Cognito Credentials.</param>
        /// <returns>The identity identifier.</returns>
        public static string GetIdentityId(CognitoAWSCredentials credentials)
        {
            return string.IsNullOrEmpty(credentials.GetCachedIdentityId())
                ? UNKNOWN_IDENTITY_ID
                    : credentials.GetCachedIdentityId();
        }

        /// <summary>
        /// A helper function to truncate a DateTime object to whole seconds.
        /// </summary>
        /// <returns>The truncated DateTime</returns>
        /// <param name="dateTime">The DateTime to be truncated.</param>
        public static DateTime TruncateToSeconds(DateTime dateTime)
        {
            return dateTime.AddTicks(-(dateTime.Ticks % TimeSpan.TicksPerSecond));
        }
    }
}

