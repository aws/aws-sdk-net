﻿using Amazon.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.S3
{
    /// <summary>
    /// A resource in an S3 Outpost
    /// </summary>
    public class S3OutpostResource
    {
        private Arn _arn;

        /// <summary>
        /// Create a new S3OutpostResource object
        /// </summary>
        /// <param name="arn"></param>
        public S3OutpostResource(Arn arn)
        {
            _arn = arn;
        }

        private string _outpostId = string.Empty;

        /// <summary>
        /// ID of the S3 Outpost
        /// </summary>
        public string OutpostId 
        {
            get { return this._outpostId; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    this._outpostId = string.Empty;
                }
                else
                {
                    if (value.Length > 63 || value.Length < 1 
                        || value.ToCharArray().Any(x => !char.IsLetterOrDigit(x) && x != '-'))
                    {
                        throw new AmazonClientException($"Invalid outpost ID: {value}. ID must contain only alphanumeric characters and dashes");
                    }

                    this._outpostId = value;
                }
            }
        }

        /// <summary>
        /// Name of the access point bucket
        /// </summary>
        public string AccessPointName { get; set; }

        /// <summary>
        /// Key for object in bucket
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// The full name of the S3 Outpost Resource
        /// </summary>
        public string FullAccessPointName
        {
            get
            {
                return $"arn:{_arn.Partition}:{_arn.Service}:{_arn.Region}:" +
                    $"{_arn.AccountId}:outpost:{OutpostId}:accesspoint:{AccessPointName}";
            }
        }
    }
}
