/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./**/*.{razor,html,cshtml}"],
  theme: {
    extend: {
      colors: {
        transparent: 'transparent',
        current: 'currentColor',
        'black-1': '#1b1b21',
        'black-2': '#333333',
      },
    }
  },
  plugins: [],
}
