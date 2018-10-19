﻿using System;

namespace Newtonsoft.Json.Linq
{
    /// <summary>
    /// Specifies the settings used when loading JSON.
    /// </summary>
    public class JsonLoadSettings
    {
        private CommentHandling _commentHandling;
        private LineInfoHandling _lineInfoHandling;
        private DuplicatePropertyNamesHandling _duplicatePropertyNamesHandling;

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonLoadSettings"/> class.
        /// </summary>
        public JsonLoadSettings()
        {
            _lineInfoHandling = LineInfoHandling.Load;
            _commentHandling = CommentHandling.Ignore;
            _duplicatePropertyNamesHandling = DuplicatePropertyNamesHandling.Ignore;
        }

        /// <summary>
        /// Gets or sets how JSON comments are handled when loading JSON.
        /// </summary>
        /// <value>The JSON comment handling.</value>
        public CommentHandling CommentHandling
        {
            get => _commentHandling;
            set
            {
                if (value < CommentHandling.Ignore || value > CommentHandling.Load)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                _commentHandling = value;
            }
        }

        /// <summary>
        /// Gets or sets how JSON line info is handled when loading JSON.
        /// </summary>
        /// <value>The JSON line info handling.</value>
        public LineInfoHandling LineInfoHandling
        {
            get => _lineInfoHandling;
            set
            {
                if (value < LineInfoHandling.Ignore || value > LineInfoHandling.Load)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                _lineInfoHandling = value;
            }
        }

        /// <summary>
        /// Gets or sets how duplicate property names are handled when loading JSON.
        /// </summary>
        /// <value>The JSON duplicate property names handling.</value>
        public DuplicatePropertyNamesHandling DuplicatePropertyNamesHandling
        {
            get => this._duplicatePropertyNamesHandling;
            set
            {
                if (value< DuplicatePropertyNamesHandling.Ignore|| value> DuplicatePropertyNamesHandling.Throw)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                this._duplicatePropertyNamesHandling = value;
            }
        }
    }
}